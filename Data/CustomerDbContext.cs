using Microsoft.EntityFrameworkCore;

namespace aspnetcoreapp.Data
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<aspnetcoreapp.Models.Customer> Customer => Set<aspnetcoreapp.Models.Customer>();
    }
}