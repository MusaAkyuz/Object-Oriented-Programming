using Microsoft.EntityFrameworkCore;

namespace FirstTry.Data
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options) { }

        public DbSet<FirstTry.Models.Customer> Customer => Set<FirstTry.Models.Customer>();
    }
}
