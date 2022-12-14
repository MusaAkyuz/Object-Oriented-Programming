using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AbbyWeb.Models;
using AbbyWeb.Data;

namespace AbbyWeb.Pages.Customer
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly CustomersDbContext _db;

        public Customers Customer { get; set; }

        public CreateModel(CustomersDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
				await _db.Customer.AddAsync(Customer);
				await _db.SaveChangesAsync();
				return RedirectToPage("../Index");
			}
            return Page();
			
        }
    }
}
