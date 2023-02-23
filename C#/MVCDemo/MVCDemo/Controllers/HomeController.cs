using Microsoft.AspNetCore.Mvc;
using MVCDemo.Data;
using MVCDemo.Models;
using NuGet.Protocol;
using OfficeOpenXml;
using System.Data.OleDb;
using System.Diagnostics;

namespace MVCDemo.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private Root data = new Root();
		private Category tempCategory = new Category();
		private Data.Process tempProcess = new Data.Process();
		private Data.Application tempApplication = new Data.Application();

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
            var connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source='C:\\Users\\muss\\Documents\\Deneme.xlsx';Extended Properties='Excel 12.0;IMEX=1;HDR=YES;'";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                OleDbDataReader dataReader;
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Uygulamalar$]", conn);
                dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
					while(dataReader.Read())
					{
						if (!String.IsNullOrEmpty(dataReader[1].ToString()) && dataReader[1].ToString() != "Function")
						{
							var category = dataReader[1].ToString();
							var process = dataReader[2].ToString();
							var risk = dataReader[3].ToString();
							var application = dataReader[4].ToString();
							var description = dataReader[5].ToString();
							var runningCheck = dataReader[8].ToString();

                        }
                    }
                    return View(data);
                }
            }
			return View();
        }

		public IActionResult Deneme(int num = 0)
		{
			if(num == 1)
			{
				return View("\\Privacy");
			}
			return View("\\Index");
		}

        public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		//public void GetDataFromExcel()
		//{
			
		//}
	}
}