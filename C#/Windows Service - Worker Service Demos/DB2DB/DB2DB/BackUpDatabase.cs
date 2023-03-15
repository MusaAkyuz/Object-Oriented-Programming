using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Data.SqlClient;

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

        public void BackUp()
        {
            SqlConnection srcConn = new SqlConnection(_sourceDBConnString);
            SqlConnection dtnConn = new SqlConnection(_destinationDBConnString);

            srcConn.Open();
            dtnConn.Open();
        }
    }
}
