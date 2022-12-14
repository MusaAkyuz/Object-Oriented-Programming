using AbbyWeb.Data;
using AbbyWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Customer
{
	[BindProperties]
	public class DeleteModel : PageModel
	{
		private readonly CustomersDbContext _db;

		public Customers Customer { get; set; }

		public DeleteModel(CustomersDbContext db)
		{
			_db = db;
		}
		public void OnGet(int id)
		{
			Customer = _db.Customer.Find(id);
		}
		public async Task<IActionResult> OnPost()
		{
			var id = _db.Customer.Find(Customer.Id);
			if (id != null)
			{
				_db.Customer.Remove(id);
				await _db.SaveChangesAsync();
				return RedirectToPage("../Index");
			}

			return Page();

		}
	}
}
