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
					Row.Add("112");
					Row.Add(dataReader["MaterialCode"].ToString());
					Row.Add(dataReader["Description"].ToString());
					Row.Add(dataReader["Unit"].ToString());
					Row.Add(dataReader["CreateDateTime"].ToString());
				}
			}

			cnn.Close();

			return Row;
		}
	}
}
