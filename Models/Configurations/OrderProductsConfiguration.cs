using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASPCore_WebMailer.Models.Configurations
{
    public class OrderProductsConfiguration : IEntityTypeConfiguration<OrderProducts>
    {
        public void Configure(EntityTypeBuilder<OrderProducts> builder)
        {
            builder
                .HasOne(pt => pt.Order)
                .WithMany(p => p.OrderProducts)
                .HasForeignKey(pt => pt.OrderId);
            builder
                .HasOne(pt => pt.Product)
                .WithMany(p => p.OrderProducts)
                .HasForeignKey(pt => pt.ProductId);
        }
    }
}
