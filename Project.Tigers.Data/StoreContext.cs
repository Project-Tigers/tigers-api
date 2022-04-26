using Project.Tigers.Domain.Catalog;
using Project.Tigers.Domain.Orders;
using Microsoft.EntityFrameworkCore;

namespace Project.Tigers.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) 
            : base(options)
        { }

        public DbSet<Item>? Items { get; set; }
        public DbSet<Order>? Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            DbInitializer.Initialize(builder);
        }
    }
}
