using System.Data.OleDb;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using OfficeOpenXml;

namespace ConnectionDensity
{ 
    class Program
    {
        //public static void Main()
        //{
        //    List<Connection> connList = new List<Connection>();
        //    var connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source='C:\\Users\\muss\\Desktop\\Connections.xlsx';Extended Properties='Excel 12.0;IMEX=1;HDR=YES;'";

        //    using (OleDbConnection conn = new OleDbConnection(connectionString))
        //    {
        //        conn.Open();
        //        OleDbDataReader dataReader;
        //        OleDbCommand cmd = new OleDbCommand("SELECT * FROM [SMBv1_Bolu_Claroty$]", conn);
        //        dataReader = cmd.ExecuteReader();

        //        if (dataReader.HasRows)
        //        {
        //            // Tüm veriler listeye çekildi.
        //            // Bu liste üzerinde arama yapılacak
        //            while (dataReader.Read())
        //            {
        //                if (!String.IsNullOrEmpty(dataReader[0].ToString()))
        //                {
        //                    connList.Add(new Connection { SourceIP = dataReader[2].ToString(), DestinationIP = dataReader[3].ToString() });
        //                }
        //            }
        //        }
        //    }

        //    // Benzersiz kaynak ip adreslerini çekiyoruz
        //    // Bu adreslerin tek tek nerelere gittiğine bakan bir döngü kuracağız
        //    // Sayılarını tutacağız
        //    var distincIP = connList.Select(t => t.SourceIP).Distinct();

        //    foreach(var data in distincIP)
        //    {
        //        // bir verinin diğer veriyle olan bağlantı sayısı
        //        var countsOfConnections = new Dictionary<string, int>();
        //        if (data != null)
        //        {
        //            var vari = connList.Where(t => t.SourceIP == data).Select(a => a.DestinationIP).Count();

        //            //Console.WriteLine(data + " : " + vari);
        //            //foreach (var conn in vari)
        //            //{
        //            //    Console.WriteLine(conn);
        //            //}
        //            //Console.WriteLine("------------------------");

        //            var vari2 = connList.Where(t => t.SourceIP == data).Select(b => b.DestinationIP).Distinct();

        //            Console.WriteLine(data + " nın taradığı tüm ipler ve sayıları");
        //            foreach (var conn in vari2)
        //            {
        //                Console.WriteLine(conn);
        //            }
        //            Console.WriteLine("------------------------");
        //        }
        //    }
        //}

        public static void Main()
        {
            // If you are a commercial business and have
            // purchased commercial licenses use the static property
            // LicenseContext of the ExcelPackage class:
            ExcelPackage.LicenseContext = LicenseContext.Commercial;

            // If you use EPPlus in a noncommercial context
            // according to the Polyform Noncommercial license:
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo("C:\\Users\\muss\\Desktop\\Connections.xlsx")))
            {        
                int row = 2;
                const int DESTCOL = 4;
                const int SOURCECOL = 3;
                var allConnectons = new Dictionary<string, int>();
                ExcelWorksheet worksheet = package.Workbook.Worksheets["SMBv1_Bolu_Claroty"];

                while (worksheet.Cells[row, SOURCECOL].Value != null)
                {
                    var keyy = worksheet.Cells[row, SOURCECOL].Value.ToString();
                    var value = worksheet.Cells[row, DESTCOL].Value.ToString();
                    var combineKey = keyy + "---" + value;

                    if(allConnectons.ContainsKey(combineKey))
                    {
                        allConnectons[combineKey] += 1;
                    }
                    else
                    {
                        allConnectons.Add(combineKey, 1);
                    }

                    row += 1;
                }

                Console.WriteLine(String.Format("{0,20}{1,20}{2,20}", "Source Ip", "Destination Ip", "ConnectionDensity"));
                foreach (var key in allConnectons.OrderBy(t => t.Value))
                {
                    Console.WriteLine(key);
                }
            }
        }
    }
}

