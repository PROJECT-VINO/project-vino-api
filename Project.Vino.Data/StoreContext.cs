using Project.Vino.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Project.Vino.Data
{

    public class StoreContext : DbContext
    {
     public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
     { }

     public DbSet<Item> Items { get; set; }
    }
}