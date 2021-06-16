using Microsoft.EntityFrameworkCore;
using skinet.Core.Entities;

namespace skinet.Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
