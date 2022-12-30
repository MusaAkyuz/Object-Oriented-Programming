using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceiptPrintConfig
{
	public class DatabaseTransaction
	{
		private static ArrayList Row = new ArrayList();

		// Get Connection String from Configuration AppConfig
		public string GetConnectionStrings(string providerName)
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
			return null;
		}

		// GetsFromDatabase
		public ArrayList QueryToArrayList(OleDbConnection cnn, string query, OleDbParameter parameter = null)
		{
			Row.Clear();
			cnn.Open();
			OleDbDataReader dataReader;
			OleDbCommand cmd = new OleDbCommand(query, cnn);
			if (parameter != null)
			{
				cmd.Parameters.Add(parameter.ParameterName, string.Format("%{0}%", parameter.Value.ToString()));
			}
			dataReader = cmd.ExecuteReader();

			if (dataReader.HasRows)
			{
				while (dataReader.Read())
				{
					var configSettings = new List<string>(ConfigurationSettings.AppSettings["ReceiverCompany1"].Split(new char[] {';'}));
					Row.Add(configSettings[0]);
					Row.Add(configSettings[1]);
					Row.Add(dataReader["MaterialCode"].ToString());
					Row.Add(dataReader["Description"].ToString());
					Row.Add(dataReader["Unit"].ToString());
					Row.Add(dataReader["CreateDateTime"].ToString());
				}
			}

			cnn.Close();

			return Row;
		}

		// Insert Operations to New Stock Button
		public void DatabaseInsert(OleDbConnection cnn, string query, List<OleDbParameter> parameters)
		{
			cnn.Open();
			OleDbCommand cmd = new OleDbCommand(query, cnn);
			foreach(var par in parameters)
			{
				cmd.Parameters.Add(par.ParameterName, par.Value);
			}
			cmd.ExecuteNonQuery();
		}

		// Insert operation for BoxCode value
		// Increase when per receipt print
		public void BoxCodeUpdate(OleDbConnection cnn, string query, OleDbParameter parameter = null)
		{
			cnn.Open();
			OleDbCommand cmd = new OleDbCommand(query, cnn);
			if(parameter != null)
			{
				cmd.Parameters.Add(parameter.ParameterName, parameter.Value);
			}
			cmd.ExecuteNonQuery();
		}
	}
}
