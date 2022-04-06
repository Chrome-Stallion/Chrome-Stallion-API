using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Chrome.Stallion.Data
{
    public class StoreContextFactory : IDesignTimeDbContextFactory<StoreContext>
    {
        public StoreContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<StoreContext>();
            optionsBuilder.UseSqlite("Data Source=../Registar.sqlite");

            return new StoreContext(optionsBuilder.Options);
        }
    }
}