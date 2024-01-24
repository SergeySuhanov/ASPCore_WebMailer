using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace ASPCore_WebMailer.Models.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .Property(x => x.Title)
                .IsRequired();

            builder
                .Property(x => x.Title)
                .HasMaxLength(100);

            builder
                .Property(x => x.Description)
                .HasMaxLength(1000);

            builder
                .Property(x => x.Price)
                .IsRequired();
        }
    }
}
