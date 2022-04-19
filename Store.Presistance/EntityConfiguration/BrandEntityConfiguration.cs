using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Models.EntityModels;

namespace Store.Presistance.EntityConfiguration
{
    internal class BrandEntityConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(brand => brand.Id);
            builder.Property(brand => brand.Name).IsRequired().HasMaxLength(50);
        }
    }
}
