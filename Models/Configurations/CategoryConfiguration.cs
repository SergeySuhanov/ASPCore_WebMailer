using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASPCore_WebMailer.Models.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .Property(x => x.Title)
                .IsRequired();

            builder
                .Property(x => x.Title)
                .HasMaxLength(100);
        }
    }
}
