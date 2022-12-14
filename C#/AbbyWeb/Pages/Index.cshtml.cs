using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AbbyWeb.Models;
using AbbyWeb.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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
			var movies = from m in _db.Customer
						 select m;
			if (!string.IsNullOrEmpty(SearchString))
			{
				movies = movies.Where(s => s.Name.Contains(SearchString));
			}

			Customer = await movies.ToListAsync();
		}

	}
}