using GroceryStore.Entities;
using Microsoft.EntityFrameworkCore;

namespace GroceryStore.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Store> Stores { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductStore> ProductStores { get; set; }
    }
}
