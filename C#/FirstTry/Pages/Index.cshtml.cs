using FirstTry.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FirstTry.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Data.CustomerDbContext _context;
        public IndexModel(Data.CustomerDbContext context)
        {
            _context = context;
        }

        public IList<Customer>? Customers { get; set; }

        public async Task OnGetAsync()
        {
            Customers = await _context.Customer.ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var contact = await _context.Customer.FindAsync(id);

            if (contact != null)
            {
                _context.Customer.Remove(contact);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}