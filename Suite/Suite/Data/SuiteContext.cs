using Microsoft.EntityFrameworkCore;
using Suite.Models;

namespace Suite.Data
{
    public class SuiteContext : DbContext
    {
        public SuiteContext (DbContextOptions<SuiteContext> options): base(options){ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>()
                .Property(price => price.Price)
                .HasPrecision(18, 2);
        }

        public DbSet<ProductModel> Product { get; set; }
        public DbSet<TagModel> Tag { get; set; }
        public DbSet<ProductTag> ProductTag { get; set; }
    }
}