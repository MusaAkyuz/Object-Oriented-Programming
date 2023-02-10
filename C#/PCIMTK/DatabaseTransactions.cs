using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Navigation;

namespace PCIMTK
{
	internal class DatabaseTransactions
	{
		private readonly string providerName = "TestDatabase";
		[Obsolete]
		private List<string> configSettings = new List<string>(ConfigurationSettings.AppSettings["CompanyCode"].Split(new char[] { ';' }));

		[Obsolete]
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
				string logtxt = ConfigurationSettings.AppSettings["LogFilePath"].ToString();
				System.Windows.MessageBox.Show("Error while connection with database\nPlease contact with your provider!", "Error", MessageBoxButton.OK);

				// Logging Error 014
				#region Logging
				if (!File.Exists(logtxt))
				{
					File.Create(logtxt);
					TextWriter tw = new StreamWriter(logtxt);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR014-GetConnectionString");
					tw.Close();
				}
				else if (File.Exists(logtxt))
				{
					TextWriter tw = new StreamWriter(logtxt, true);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR014-GetConnectionString");
					tw.Close();
				}
				#endregion
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
					string query = "SELECT MaterialCode, Description, Unit FROM Stock WHERE CompanyCode LIKE '" + configSettings[0].ToString() + "'";

					if (filter != null)
					{
						query += " AND (MaterialCode LIKE '%" + filter + "%' OR Description LIKE '%" + filter + "%')";
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
					string logtxt = ConfigurationSettings.AppSettings["LogFilePath"].ToString();
					System.Windows.MessageBox.Show("Error while reading data from database\nPlease contact with your provider!", "Error", MessageBoxButton.OK);

					// Logging Error 015
					#region Logging
					if (!File.Exists(logtxt))
					{
						File.Create(logtxt);
						TextWriter tw = new StreamWriter(logtxt);
						tw.WriteLine(DateTime.Now.ToString() + " : ERROR015-GetData");
						tw.Close();
					}
					else if (File.Exists(logtxt))
					{
						TextWriter tw = new StreamWriter(logtxt, true);
						tw.WriteLine(DateTime.Now.ToString() + " : ERROR015-GetData");
						tw.Close();
					}
					#endregion
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
						string query = "INSERT INTO Stock (MaterialCode, Description, Unit, CreateDateTime, CompanyCode) VALUES (@code, @desc, @unit, @date, @companyCode)";

						List<OleDbParameter> parameter = new List<OleDbParameter>();
						parameter.Add(new OleDbParameter("@code", f.mtrlCodeTxtBox.Text));
						parameter.Add(new OleDbParameter("@desc", f.descriptionTxtBox.Text));
						parameter.Add(new OleDbParameter("@unit", f.unitComboBox.SelectedItem.ToString()));
						parameter.Add(new OleDbParameter("@date", DateTime.Now.ToString("dd-MM-yyyy h:mm:ss tt")));
						parameter.Add(new OleDbParameter("@companyCode", configSettings[0].ToString()));

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
						string logtxt = ConfigurationSettings.AppSettings["LogFilePath"].ToString();
						System.Windows.MessageBox.Show("Error while Insertion date format to database\nPlease contact with your provider!", "Error", MessageBoxButton.OK);

						// Logging Error 016
						#region Logging
						if (!File.Exists(logtxt))
						{
							File.Create(logtxt);
							TextWriter tw = new StreamWriter(logtxt);
							tw.WriteLine(DateTime.Now.ToString() + " : ERROR015-InsertData-FormatException");
							tw.Close();
						}
						else if (File.Exists(logtxt))
						{
							TextWriter tw = new StreamWriter(logtxt, true);
							tw.WriteLine(DateTime.Now.ToString() + " : ERROR015-InsertData-FormatException");
							tw.Close();
						}
						#endregion
					}
					catch
					{
						string logtxt = ConfigurationSettings.AppSettings["LogFilePath"].ToString();
						System.Windows.MessageBox.Show("Error while Insertion data to database\nPlease contact with your provider!", "Error", MessageBoxButton.OK);

						// Logging Error 017
						#region Logging
						if (!File.Exists(logtxt))
						{
							File.Create(logtxt);
							TextWriter tw = new StreamWriter(logtxt);
							tw.WriteLine(DateTime.Now.ToString() + " : ERROR017-InsertData-GeneralException");
							tw.Close();
						}
						else if (File.Exists(logtxt))
						{
							TextWriter tw = new StreamWriter(logtxt, true);
							tw.WriteLine(DateTime.Now.ToString() + " : ERROR017-InsertData-GeneralException");
							tw.Close();
						}
						#endregion
					}
					finally
					{
						cnn.Close();
					}
				}
				
			}
			else
			{
				System.Windows.MessageBox.Show("Required fields must be correctly filled", "Warning");
			}

			return false;
		}

		[Obsolete]
		public string GetBoxCode()
		{
			using (OleDbConnection cnn = new OleDbConnection(GetConnectionStrings(providerName)))
			{
				try
				{
					string boxCode = "0";
					string query2 = "SELECT LastBoxCode FROM Box WHERE CompanyCode LIKE '" + configSettings[0].ToString() + "'";
					OleDbDataReader dataReader;
					OleDbCommand cmd = new OleDbCommand(query2, cnn);

					cnn.Open();

					dataReader = cmd.ExecuteReader();
					if (dataReader.HasRows)
					{
						while (dataReader.Read())
						{
							boxCode = dataReader["LastBoxCode"].ToString();
						}
						return boxCode;
					}
					else
					{
						return null;
					}
				}
				catch
				{
					string logtxt = ConfigurationSettings.AppSettings["LogFilePath"].ToString();
					System.Windows.MessageBox.Show("Error while reading box code number from database\nPlease contact with your provider!", "Error", MessageBoxButton.OK);

					// Logging Error 018
					#region Logging
					if (!File.Exists(logtxt))
					{
						File.Create(logtxt);
						TextWriter tw = new StreamWriter(logtxt);
						tw.WriteLine(DateTime.Now.ToString() + " : ERROR018-GetBoxCode");
						tw.Close();
					}
					else if (File.Exists(logtxt))
					{
						TextWriter tw = new StreamWriter(logtxt, true);
						tw.WriteLine(DateTime.Now.ToString() + " : ERROR018-GetBoxCode");
						tw.Close();
					}
					#endregion
				}
				finally
				{ 
					cnn.Close(); 
				}

				return null;
			}
		}

		[Obsolete]
		public void UpdateBoxCode(int boxCode)
		{
			using (OleDbConnection cnn = new OleDbConnection(GetConnectionStrings(providerName)))
			{
				try
				{
					string query = "UPDATE Box SET LastBoxCode = @code WHERE CompanyCode LIKE '" + configSettings[0].ToString() + "'";

					List<OleDbParameter> parameter = new List<OleDbParameter>();
					parameter.Add(new OleDbParameter("@code", boxCode.ToString()));

					cnn.Open();
					OleDbCommand cmd = new OleDbCommand(query, cnn);
					foreach (var par in parameter)
					{
						cmd.Parameters.Add(par.ParameterName, par.Value);
					}
					cmd.ExecuteNonQuery();
				}
				catch
				{
					string logtxt = ConfigurationSettings.AppSettings["LogFilePath"].ToString();
					System.Windows.MessageBox.Show("Error while inserting box code to database\nPlease contact with your provider!", "Error", MessageBoxButton.OK);

					// Logging Error 020
					#region Logging
					if (!File.Exists(logtxt))
					{
						File.Create(logtxt);
						TextWriter tw = new StreamWriter(logtxt);
						tw.WriteLine(DateTime.Now.ToString() + " : ERROR020-UpdateBoxCode");
						tw.Close();
					}
					else if (File.Exists(logtxt))
					{
						TextWriter tw = new StreamWriter(logtxt, true);
						tw.WriteLine(DateTime.Now.ToString() + " : ERROR020-UpdateBoxCode");
						tw.Close();
					}
					#endregion
				}
				finally
				{
					cnn.Close();
				}
			}
		}

		[Obsolete]
		public void AddNewCompanyBoxCode(int boxCode)
		{
			using (OleDbConnection cnn = new OleDbConnection(GetConnectionStrings(providerName)))
			{
				try
				{
					string query = "INSERT INTO Box (CompanyCode, LastBoxCode) VALUES (@code, @lastBoxCode)";

					List<OleDbParameter> parameter = new List<OleDbParameter>();
					parameter.Add(new OleDbParameter("@code", configSettings[0].ToString()));
					parameter.Add(new OleDbParameter("@lastBoxCode", boxCode.ToString()));

					cnn.Open();
					OleDbCommand cmd = new OleDbCommand(query, cnn);
					foreach (var par in parameter)
					{
						cmd.Parameters.Add(par.ParameterName, par.Value);
					}
					cmd.ExecuteNonQuery();
				}
				catch
				{
					string logtxt = ConfigurationSettings.AppSettings["LogFilePath"].ToString();
					System.Windows.MessageBox.Show("Error while inserting box code to database\nPlease contact with your provider!", "Error", MessageBoxButton.OK);

					// Logging Error 021
					#region Logging
					if (!File.Exists(logtxt))
					{
						File.Create(logtxt);
						TextWriter tw = new StreamWriter(logtxt);
						tw.WriteLine(DateTime.Now.ToString() + " : ERROR021-AddNewCompanyBoxCode");
						tw.Close();
					}
					else if (File.Exists(logtxt))
					{
						TextWriter tw = new StreamWriter(logtxt, true);
						tw.WriteLine(DateTime.Now.ToString() + " : ERROR021-AddNewCompanyBoxCode");
						tw.Close();
					}
					#endregion
				}
				finally
				{
					cnn.Close();
				}
			}
		}
	}
}
