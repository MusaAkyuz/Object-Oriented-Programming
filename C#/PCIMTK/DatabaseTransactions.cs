using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCIMTK
{
	internal class DatabaseTransactions
	{
		private readonly string providerName = "TestDatabase";

		public static string GetConnectionStrings(string providerName)
		{
			try
			{
				ConnectionStringSettingsCollection settings =
				ConfigurationManager.ConnectionStrings;

				if (settings != null)
				{
					foreach (ConnectionStringSettings cs in settings)
					{
						if (cs.ProviderName.ToString() == providerName)
						{
							return cs.ConnectionString;
						}
					}
				}
			}
			catch
			{
				MessageBox.Show("Error when getting Database Connection Information \nPlease contact with provider.");
				Form1 f = new Form1();
				f.Close();
			}

			return null;
		}

		[Obsolete]
		public void GetData(Form1 f, string filter = null)
		{
			using (OleDbConnection cnn = new OleDbConnection(GetConnectionStrings(providerName)))
			{
				try
				{
					string query = "SELECT MaterialCode, Description, Unit FROM Stock";
					var configSettings = new List<string>(ConfigurationSettings.AppSettings["Arcelik"].Split(new char[] { ';' }));

					if (filter != null)
					{
						query += " WHERE MaterialCode LIKE '%" + filter + "%' OR Description LIKE '%" + filter + "%'";
					}

					cnn.Open();

					OleDbDataReader dataReader;
					OleDbCommand cmd = new OleDbCommand(query, cnn);
					dataReader = cmd.ExecuteReader();

					if (dataReader.HasRows)
					{
						f.stockView.Rows.Clear();

						while (dataReader.Read())
						{
							DataGridViewRow newRow = new DataGridViewRow();
							newRow.CreateCells(f.stockView);
							// Company Code = App.config Company Code
							newRow.Cells[0].Value = configSettings[0];
							//Company Name = App.config Company Name
							newRow.Cells[1].Value = configSettings[1];
							// Material Code
							newRow.Cells[2].Value = dataReader["MaterialCode"].ToString();
							// Description
							newRow.Cells[3].Value = dataReader["Description"].ToString();
							// Unit
							newRow.Cells[4].Value = dataReader["Unit"].ToString();

							f.stockView.Rows.Add(newRow);
						}
					}
				}
				catch 
				{
					MessageBox.Show("Error while reading data from Database. Please contact with provider");
					f.Close();
				}
				finally
				{
					cnn.Close();
				}
			}
		}

		[Obsolete]
		public bool InsertData(Form1 f)
		{
			if (UserModeDefaults.RequirementControlAddingMode(f))
			{
				//Database Insert
				using (OleDbConnection cnn = new OleDbConnection(GetConnectionStrings(providerName)))
				{
					try
					{
						string query = "INSERT INTO Stock (MaterialCode, Description, Unit, CreateDateTime) VALUES (@code, @desc, @unit, @date)";

						List<OleDbParameter> parameter = new List<OleDbParameter>();
						parameter.Add(new OleDbParameter("@code", f.mtrlCodeTxtBox.Text));
						parameter.Add(new OleDbParameter("@desc", f.descriptionTxtBox.Text));
						parameter.Add(new OleDbParameter("@unit", f.unitComboBox.SelectedItem.ToString()));
						parameter.Add(new OleDbParameter("@date", DateTime.Now.ToString("dd-MM-yyyy h:mm:ss tt")));

						cnn.Open();
						OleDbCommand cmd = new OleDbCommand(query, cnn);
						foreach (var par in parameter)
						{
							cmd.Parameters.Add(par.ParameterName, par.Value);
						}
						cmd.ExecuteNonQuery();

						return true;
					}
					catch (System.FormatException)
					{
						MessageBox.Show("Date format exception!");
					}
					catch
					{
						MessageBox.Show("Error while inserting new values to Database.\nPlease contact with provider.");
					}
					finally
					{
						cnn.Close();
					}
				}
				
			}
			else
			{
				MessageBox.Show("Fill correctly required contents!");
			}

			return false;
		}

		public string GetBoxCode()
		{
			using (OleDbConnection cnn = new OleDbConnection(GetConnectionStrings(providerName)))
			{
				try
				{
					string boxCode = "0";
					string query2 = "SELECT TOP 1 * FROM Box ORDER BY Id DESC";
					OleDbDataReader dataReader;
					OleDbCommand cmd = new OleDbCommand(query2, cnn);

					cnn.Open();

					dataReader = cmd.ExecuteReader();
					if (dataReader.HasRows)
					{
						while (dataReader.Read())
						{
							boxCode = dataReader["Id"].ToString();
						}
						return boxCode;
					}
				}
				catch
				{
					MessageBox.Show("Error while reading BoxCode number.\nPlease contact with provider.");
				}
				finally
				{ 
					cnn.Close(); 
				}

				return "0";
			}
		}

		[Obsolete]
		public void UpdateBoxCode()
		{
			using (OleDbConnection cnn = new OleDbConnection(GetConnectionStrings(providerName)))
			{
				try
				{
					string query = "INSERT INTO Box (BoxCode) VALUES (@code)";
					OleDbParameter parameter = new OleDbParameter();
					parameter.ParameterName = "@code";
					parameter.Value = DateTime.Now.ToString();
				
					cnn.Open();
					OleDbCommand cmd = new OleDbCommand(query, cnn);
					if (parameter != null)
					{
						cmd.Parameters.Add(parameter.ParameterName, parameter.Value);
					}
					cmd.ExecuteNonQuery();
				}
				catch
				{
					MessageBox.Show("Error while saving BoxCode number.\nPlease contact with provider.");
				}
				finally
				{
					cnn.Close();
				}
			}
		}

	}
}
