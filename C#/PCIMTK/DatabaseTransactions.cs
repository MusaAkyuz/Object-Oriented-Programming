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
		private static string logtxt = System.Configuration.ConfigurationManager.AppSettings["LogFilePath"].ToString();

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
					string query2 = "SELECT TOP 1 * FROM Box ORDER BY Id DESC";
					OleDbDataReader dataReader;
					OleDbCommand cmd = new OleDbCommand(query2, cnn);

					cnn.Open();

					dataReader = cmd.ExecuteReader();
					if (dataReader.HasRows)
					{
						while (dataReader.Read())
						{
							boxCode = dataReader["BoxCode"].ToString();
						}
						return boxCode;
					}
				}
				catch
				{
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
		public string GetBoxCodeId()
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
					System.Windows.MessageBox.Show("Error while reading box code number from database\nPlease contact with your provider!", "Error", MessageBoxButton.OK);

					// Logging Error 019
					#region Logging
					if (!File.Exists(logtxt))
					{
						File.Create(logtxt);
						TextWriter tw = new StreamWriter(logtxt);
						tw.WriteLine(DateTime.Now.ToString() + " : ERROR019-GetBoxCodeId");
						tw.Close();
					}
					else if (File.Exists(logtxt))
					{
						TextWriter tw = new StreamWriter(logtxt, true);
						tw.WriteLine(DateTime.Now.ToString() + " : ERROR019-GetBoxCodeId");
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
		public void UpdateBoxCode()
		{
			using (OleDbConnection cnn = new OleDbConnection(GetConnectionStrings(providerName)))
			{
				try
				{
					string query = "INSERT INTO Box (BoxCode, CreateDateTime) VALUES (@code, @date)";

					const int codeLength = 20;
					var companyCode = configSettings[0].ToString();
					var yearLast2Char = DateTime.Now.ToString("yy");
					var lastBoxCode = (Convert.ToUInt32(GetBoxCodeId()) + 1).ToString();
					var digit = codeLength - companyCode.Length - yearLast2Char.Length - lastBoxCode.Length;
					var zeros = new string('0', digit);

					List<OleDbParameter> parameter = new List<OleDbParameter>();
					parameter.Add(new OleDbParameter("@code", companyCode + yearLast2Char + zeros + (lastBoxCode)));
					parameter.Add(new OleDbParameter("@date", DateTime.Now.ToString("dd-MM-yyyy h:mm:ss tt")));

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

	}
}
