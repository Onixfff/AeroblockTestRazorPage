using Aeroblock.DataAccess.Rail.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class SiloBalanceConfiguration : IEntityTypeConfiguration<SiloBalanceEntity>
{
    public void Configure(EntityTypeBuilder<SiloBalanceEntity> builder)
    {
        builder
            .HasIndex(x => x.Id)
            .IsUnique(true);
        builder
            .Property(x => x.Id)
            .HasMaxLength(11)
            .IsRequired(true);

        builder
            .Property(x => x.Manufactur)
            .HasMaxLength(256)
            .IsRequired(false);

        builder
            .Property(x => x.SiloNum)
            .HasMaxLength(11)
            .IsRequired(false);

        builder
            .Property(x => x.SiloMaterialName)
            .HasMaxLength(256)
            .IsRequired(false);

        builder
            .Property(x => x.SiloNameSendler)
            .HasMaxLength(256)
            .IsRequired(false);

        builder
            .Property(x => x.Weight)
            .HasColumnType("float(10, 0)")
            .IsRequired(false);

        builder
            .Property(x => x.MaxWeight)
            .HasColumnType("float")
            .IsRequired(false);
    }
}