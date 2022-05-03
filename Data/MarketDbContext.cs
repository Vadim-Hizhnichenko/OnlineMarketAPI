using Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class MarketDbContext : DbContext
    {
        public MarketDbContext(DbContextOptions<MarketDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
