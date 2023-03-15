using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Data.SqlClient;
using System.ComponentModel;

namespace DB2DB
{
    public class BackUpDatabase
    {
        private string _sourceDBConnString;
        private string _destinationDBConnString;

        public BackUpDatabase(string sourceDB, string destinationDB)
        {
            _sourceDBConnString = ReadConnStringFromAppSetting.GetConnString(sourceDB);
            _destinationDBConnString = ReadConnStringFromAppSetting.GetConnString(destinationDB);
        }

        public async Task<string> BackUp()
        {
            try
            {
                SqlConnection srcConn = new SqlConnection(_sourceDBConnString);
                SqlConnection dtnConn = new SqlConnection(_destinationDBConnString);

                //return String.IsNullOrEmpty(_sourceDBConnString) ? "Null": _sourceDBConnString.ToString();

                srcConn.Open();
                dtnConn.Open();

                var readSql = "SELECT Name, Surname FROM People";

                SqlCommand srcCmd = new SqlCommand(readSql, srcConn);
                SqlDataReader srcReader = srcCmd.ExecuteReader();

                while (srcReader.Read())
                {
                    var writeSql = "INSERT INTO Customer (CustomerName, CustomerSurname) VALUES (@name, @surname)";

                    using (var cmd = new SqlCommand(writeSql, dtnConn))
                    {
                        cmd.Parameters.AddWithValue("@name", srcReader["Name"].ToString());
                        cmd.Parameters.AddWithValue("@surname", srcReader["Surname"].ToString());

                        cmd.ExecuteNonQuery();
                    }
                }


                Thread.Sleep(30000);
                //Task.Delay(TimeSpan.FromMilliseconds(30000));

                srcConn.Close();
                dtnConn.Close();

                return "Succesfull operation";
            }
            catch(Exception ex)
            {
                return "Error : " + ex.Message;
            }
        }
    }
}
