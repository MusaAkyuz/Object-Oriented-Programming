using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AbbyWeb.Models;
using AbbyWeb.Data;

namespace AbbyWeb.Pages.Customer
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly CustomersDbContext _db;

        public Customers Customer { get; set; }

        public EditModel(CustomersDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            Customer = _db.Customer.Find(id);
			//Customer = _db.Customer.FirstOrDefault(u=>u.Id == id);
			//Customer = _db.Customer.SingleOrDefault(u => u.Id == id);
			//Customer = _db.Customer.Where(u => u.Id == id).FirstOrDefault();
		}
        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
			    _db.Customer.Update(Customer);
				await _db.SaveChangesAsync();
				return RedirectToPage("../Index");
			}
            return Page();
        }
    }
}
