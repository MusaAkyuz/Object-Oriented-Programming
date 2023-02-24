using ExcelReadWithOleDbDemo;
using System;
using System.Data;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace ExcelRead
{
    class Program
    {
        public static void Main(string[] args)
        {
            var connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source='C:\\Users\\muss\\Documents\\Deneme.xlsx';Extended Properties='Excel 12.0;IMEX=1;HDR=YES;'";
            List<DataModel> list = new List<DataModel>();

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                OleDbDataReader dataReader;
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Uygulamalar$]", conn);
                dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        if (!String.IsNullOrEmpty(dataReader[1].ToString()) && dataReader[1] != "Function")
                        {
                            Console.WriteLine(dataReader[1].ToString());
                            list.Add(new DataModel { category = dataReader[1].ToString(), process = dataReader[2].ToString(), applicaiton = dataReader[4].ToString() });
                        }
                    }
                }
            }
            Console.WriteLine("---------");

            var categories = list.GroupBy(x => x.category)
            .Select(t => new
            {
                Category = t.Key,
                ProcApp = t.Select(x => new
                {
                    Process = x.process,
                    Application = list
                        .Where(y => y.category != null
                                    && y.process.Contains(x.process)
                                    && y.category.Contains(t.Key)).Select(y =>
                                        new
                                        {
                                            Category = y.category,
                                            Process = y.process,
                                            Application = y.applicaiton,
                                        }
                                    )
                }).DistinctBy(x => x.Process)
            });

            //var categories = list.GroupBy(x => x.category).Select(t => new { 
            //                                                                Category = t.Key, 
            //                                                                ProcessList = t.Select(y => new { 
            //                                                                                                Process = y.process, 
            //                                                                                                Application = list.Where(l => l.category != null &&
            //                                                                                                                              l.process.Contains(y.process) &&
            //                                                                                                                              l.category.Contains(t.Key)).Select()})});

            var cat = list.GroupBy(x => x.category).Select(t => t.)

            //foreach (var category in categories)
            //{
            //    category.
            //}
        }
    }
}