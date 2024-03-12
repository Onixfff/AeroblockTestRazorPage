using Aeroblock.DataAccess.Rail.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class DeliveryTermConfiguration : IEntityTypeConfiguration<DeliveryTermEntity>
{
    public void Configure(EntityTypeBuilder<DeliveryTermEntity> builder)
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
            .HasMaxLength(245)
            .IsRequired(false);
    }
}