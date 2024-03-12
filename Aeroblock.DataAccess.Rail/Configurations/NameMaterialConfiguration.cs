using Aeroblock.DataAccess.Rail.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class NameMaterialConfiguration : IEntityTypeConfiguration<NameMaterialEntity>
{
    public void Configure(EntityTypeBuilder<NameMaterialEntity> builder)
    {
        builder
            .HasIndex(x => x.Id)
            .IsUnique(true);
        builder
            .Property(x => x.Id)
            .HasMaxLength(11)
            .IsRequired(true);

        builder
            .Property(x => x.Name)
            .HasMaxLength(45)
            .IsRequired(false);

        builder
            .Property(x => x.Group)
            .HasMaxLength(45)
            .IsRequired(false);
    }
}

