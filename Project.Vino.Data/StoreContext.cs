using Project.Vino.Domain.Catalog;
using Microsoft.EntityFrameworkCore;
using Project.Vino.Domain.Orders;

namespace Project.Vino.Data
{

    public class StoreContext : DbContext
    {
     public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
     { }

     public DbSet<Item> Items { get; set; }

     protected override void OnModelCreating(ModelBuilder builder)
     {
            base.OnModelCreating(builder);
            DbInitializer.Initialize(builder);
     }

     public DbSet<Order> Orders { get; set; }

     public void UpdateItem(Item item)
     {
              Items.Update(item);
              SaveChanges();
     }
     
    }
}