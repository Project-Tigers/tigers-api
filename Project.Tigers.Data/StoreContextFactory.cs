using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Project.Tigers.Data
{
    public class StoreContextFactory : IDesignTimeDbContextFactory<StoreContext>
    {
      public StoreContext CreateDbContext(String[] args)
      {
          var optionsBuilder = new DbContextOptionsBuilder<StoreContext>();
          optionsBuilder.UseSqlite("Data Source=../Registrar.sqlite");

          return new StoreContext(optionsBuilder.Options);
      }  
    }
}