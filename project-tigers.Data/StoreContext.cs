using Project.Tigers.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace project.tigers.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        { }

        public DbSet<Item> Items { get; set; }
    }
}