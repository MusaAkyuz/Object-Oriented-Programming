using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AbbyWeb.Data;
using AbbyWeb.Models;

namespace AbbyWeb.Pages.Customer
{
    public class IndexModel : PageModel
    {
        private readonly CustomersDbContext _db;
        public IndexModel(CustomersDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Customers> Customer { get; set; }
        public void OnGet()
        {
            Customer = _db.Customer;
        }
    }
}
