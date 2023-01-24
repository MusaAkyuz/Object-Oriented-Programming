using System;
using System.Text;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace ExeDemo
{
	class Program
	{
		static void Main()
		{
			string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database\\Arcelik2.mdb";

			OleDbConnection conn = new OleDbConnection(connection);

			try
			{
				Console.WriteLine("Openning Connection ...");

				//open connection
				conn.Open();

				Console.WriteLine("Connection successful!");
			}
			catch (Exception e)
			{
				Console.WriteLine("Error: " + e.Message);
			}

			Console.Read();
		}
	}
}