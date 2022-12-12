using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ReadDataFromWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            
        }

        public void OnPost()
        {
			string cnnString = "Data Source=(localdb)\\MSSQLLocalDB;" +
				"Initial Catalog=Customer;" +
				"Integrated Security=True;" +
				"Connect Timeout=30;" +
				"Encrypt=False;" +
				"TrustServerCertificate=False;" +
				"ApplicationIntent=ReadWrite;" +
				"MultiSubnetFailover=False;";

			SqlConnection cnn = new SqlConnection(cnnString);

			string name = Request.Form["name"];
			string surname = Request.Form["surname"];
			int identitiy = Int32.Parse(Request.Form["identity"]);

            SqlCommand cmd = new SqlCommand("INSERT INTO Customers (Name, Surname, Identity) VALUES (@param1, @param2, @param3)");
            cmd.Parameters.Add(new SqlParameter("@param1", name));
			cmd.Parameters.Add(new SqlParameter("@param2", surname));
			cmd.Parameters.Add(new SqlParameter("@param3", identitiy));

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
		}

    }
}