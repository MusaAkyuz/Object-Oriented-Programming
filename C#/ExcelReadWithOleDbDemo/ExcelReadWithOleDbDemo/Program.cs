using System;
using System.Data;
using System.Data.OleDb;

namespace ExcelRead
{
    class Program
    {
        public static void Main(string[] args)
        {
            var connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source='C:\\Users\\muss\\Documents\\Deneme1.xlsx';Extended Properties='Excel 12.0;IMEX=1;HDR=YES;'";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                OleDbDataReader dataReader;
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Sheet1$]", conn);
                dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Console.WriteLine(dataReader[0].ToString());
                    }
                }
            }
        }
    }
}