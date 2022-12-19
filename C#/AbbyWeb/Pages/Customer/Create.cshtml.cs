using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AbbyWeb.Models;
using AbbyWeb.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Collections;

namespace AbbyWeb.Pages.Customer
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly CustomersDbContext _db;

        public Customers Customer { get; set; }

		public string GetErrorMessage() =>
		$"Not be same.";

		public CreateModel(CustomersDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {

			string cnnstr = "Data Source=.;Initial Catalog=Customer;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

			string query = "SELECT Id FROM Customer WHERE IdentityNo = " + Customer.IdentityNo;

			SqlConnection cnn = new SqlConnection(cnnstr);
			cnn.Open();

			SqlCommand cmd = new SqlCommand(query, cnn);
			SqlDataReader reader = cmd.ExecuteReader();

			ArrayList Isimler = new ArrayList();

			while (reader.Read())
			{
				Isimler.Add(reader["Id"]);
			}
			//tc = tc.Where(s => s.IdentityNo.Contains(Customer.IdentityNo));

			if(Isimler.Count == 0)
            {
				if (ModelState.IsValid)
				{
					await _db.Customer.AddAsync(Customer);
					await _db.SaveChangesAsync();
					return RedirectToPage("../Index");
				}
			}
            else
            {
				TempData["error"] = "Not be same";
				return Page();
			}

			reader.Close();
			cnn.Close();

			return Page();

			
			
        }
    }
}
