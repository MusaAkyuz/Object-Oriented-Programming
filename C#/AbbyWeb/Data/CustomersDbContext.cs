using AbbyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace AbbyWeb.Data
{
    public class CustomersDbContext : DbContext
    {
        public CustomersDbContext(DbContextOptions<CustomersDbContext> options) : base(options)
        {

        }
        public DbSet<Customers> Customer { get; set; }
    }
}
