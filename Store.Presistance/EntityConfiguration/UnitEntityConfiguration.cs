using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Models.EntityModels;

namespace Store.Presistance.EntityConfiguration
{
    internal class UnitEntityConfiguration : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
        {
            builder.HasKey(unit => unit.Id);
            builder.Property(unit => unit.Name).IsRequired().HasMaxLength(50);
        }
    }
}
