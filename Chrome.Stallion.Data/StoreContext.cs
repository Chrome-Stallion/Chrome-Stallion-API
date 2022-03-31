using Chrome.Stallion.Domain.Catalog;
using Microsoft.EntityFrameworkCore;
using Chrome.Stallion.Domain.Orders;


namespace Chrome.Stallion.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        { }
        
        public DbSet<Item> Items { get; set; }

        public DbSet<Order> Orders { get; set; }
        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            DbInitializer.Initialize(builder);
        }
    }
}

