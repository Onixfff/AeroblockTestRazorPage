using Aeroblock.DataAccess.Rail.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class SkladConfiguration : IEntityTypeConfiguration<SkladEntity>
{
    public void Configure(EntityTypeBuilder<SkladEntity> builder)
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
            .HasMaxLength(50)
            .IsRequired(true);
        builder
            .Property(x => x.NameMaterial)
            .HasMaxLength(128)
            .IsRequired(true);
    }
}
