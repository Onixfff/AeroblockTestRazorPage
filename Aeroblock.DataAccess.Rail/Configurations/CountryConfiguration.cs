using Aeroblock.DataAccess.Rail.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CountryConfiguration : IEntityTypeConfiguration<CountryEntity>
{
    public void Configure(EntityTypeBuilder<CountryEntity> builder)
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
    }
}

public class ManufacturerConfiguration : IEntityTypeConfiguration<ManufacturerEntity>
{
    public void Configure(EntityTypeBuilder<ManufacturerEntity> builder)
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

        builder.Property(x => x.Adress)
            .HasMaxLength(45)
            .IsRequired(false);

        builder
            .Property(x => x.Phone)
            .HasMaxLength(145)
            .IsRequired(false);

        builder
            .Property(x => x.Email)
            .HasMaxLength(145)
            .IsRequired(false);

        builder
            .Property(x => x.Site)
            .HasMaxLength(145)
            .IsRequired(false);

        builder
            .Property(x => x.Face)
            .HasMaxLength(45)
            .IsRequired(false);

        builder
            .Property(x => x.ContactFace)
            .HasMaxLength(45)
            .IsRequired(false);
    }
}