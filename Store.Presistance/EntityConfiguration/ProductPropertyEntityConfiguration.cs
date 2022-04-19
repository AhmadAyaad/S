using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Models.EntityModels;

namespace Store.Presistance.EntityConfiguration
{
    internal class ProductPropertyEntityConfiguration : IEntityTypeConfiguration<ProductProperty>
    {
        public void Configure(EntityTypeBuilder<ProductProperty> builder)
        {
            builder.HasKey(productProperty => new { productProperty.ProductId, productProperty.PropertyId });
            builder.HasOne(productProperty => productProperty.Product)
                   .WithMany(product => product.ProductProperties)
                   .HasForeignKey(productProperty => productProperty.ProductId);
            builder.HasOne(productProperty => productProperty.Property)
                   .WithMany(property => property.ProductProperties)
                   .HasForeignKey(productProperty => productProperty.PropertyId);
        }
    }
}
