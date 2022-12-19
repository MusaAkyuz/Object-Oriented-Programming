using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AbbyWeb.Models;
using AbbyWeb.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AbbyWeb.Pages
{
	public class IndexModel : PageModel
	{
		private readonly CustomersDbContext _db;
		public IEnumerable<Customers> Customer { get; set; }

		public Customers Cus { get; set; }

		public IndexModel(CustomersDbContext db)
		{
			_db = db;
		}

		[BindProperty(SupportsGet = true)]
		public string? SearchString { get; set; }
		public async Task OnGetAsync()
		{
			var namee = from m in _db.Customer
						 select m;
			if (!string.IsNullOrEmpty(SearchString))
			{
				namee = namee.Where(s => s.IdentityNo.Contains(SearchString) || s.Surname.Contains(SearchString) || s.IdentityNo.Contains(SearchString));

			}

			Customer = await namee.ToListAsync();
		}
	}
}