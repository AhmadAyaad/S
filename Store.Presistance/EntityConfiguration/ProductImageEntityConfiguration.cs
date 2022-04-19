using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Models.EntityModels;

namespace Store.Presistance.EntityConfiguration
{
    internal class ProductImageEntityConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.HasKey(productImage => productImage.Id);
            builder.Property(productImage => productImage.URL).IsRequired().HasMaxLength(255);
        }
    }
}
