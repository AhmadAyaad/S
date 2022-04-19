using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Models.EntityModels;

namespace Store.Presistance.EntityConfiguration
{
    internal class PropertyEntityConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.HasKey(property => property.Id);
            builder.Property(property => property.NameAR).IsRequired().HasMaxLength(50);
            builder.Property(property => property.NameEN).IsRequired().HasMaxLength(50);
            builder.Property(property => property.ValueAR).IsRequired().HasMaxLength(100);
            builder.Property(property => property.ValueEN).IsRequired().HasMaxLength(100);
        }
    }
}
