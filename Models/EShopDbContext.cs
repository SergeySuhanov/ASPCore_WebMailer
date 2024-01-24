using ASPCore_WebMailer.Models.Configurations;
using Microsoft.EntityFrameworkCore;

namespace ASPCore_WebMailer.Models
{
    public class EShopDbContext : DbContext
    {
        public EShopDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Product>()
                .Property(x => x.Title)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .Property(x => x.Title)
                .HasMaxLength(100);*/

            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderProductsConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderProducts> OrderProducts { get; set; }
    }
}
