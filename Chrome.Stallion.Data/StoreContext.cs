﻿using Chrome.Stallion.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Chrome.Stallion.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        { }
        
        public DbSet<Item> Items { get; set; }
    }
}
