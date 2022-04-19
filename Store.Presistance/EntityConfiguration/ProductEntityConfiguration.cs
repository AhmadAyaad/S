using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Models.EntityModels;

namespace Store.Presistance.EntityConfiguration
{
    internal class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.NameAR).IsRequired().HasMaxLength(50);
            builder.Property(p => p.NameEN).IsRequired().HasMaxLength(50);
            builder.Property(p => p.DescriptionAR).IsRequired().HasMaxLength(255);
            builder.Property(p => p.DescriptionEN).IsRequired().HasMaxLength(255);
            builder.HasOne(product => product.Unit)
                   .WithMany(unit => unit.Products)
                   .HasForeignKey(product => product.UnitId);
            builder.HasOne(product => product.Brand)
                   .WithMany(brand => brand.Products)
                   .HasForeignKey(product => product.BrandId);
            builder.HasMany(product => product.ProductImages)
                   .WithOne(productImage => productImage.Product)
                   .HasForeignKey(productImage => productImage.ProductId);
        }
    }
}
