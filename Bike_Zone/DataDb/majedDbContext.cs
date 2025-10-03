using Bike_Zone.Models;
using Microsoft.EntityFrameworkCore;

namespace Bike_Zone.DataDb
{
    public class majedDbContext : DbContext
    {
        public majedDbContext(DbContextOptions<majedDbContext> options) : base(options)
        {
            
        }

        public DbSet<Shop> Shops { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseItem> PurchaseItems { get; set; }
    }
}
