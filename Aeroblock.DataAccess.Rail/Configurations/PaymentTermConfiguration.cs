using Aeroblock.DataAccess.Rail.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class PaymentTermConfiguration : IEntityTypeConfiguration<PaymentTermEntity>
{
    public void Configure(EntityTypeBuilder<PaymentTermEntity> builder)
    {
        builder
            .HasIndex(x => x.Id)
            .IsUnique(true);
        builder
            .Property(x => x.Id)
            .HasMaxLength(11)
            .IsRequired(true);

        builder
            .Property(x => x.Prepayment)
            .HasMaxLength(11)
            .IsRequired(false);

        builder
            .Property(x => x.PaymentFinal)
            .HasMaxLength(11)
            .IsRequired(false);

        builder
            .Property(x => x.Delay)
            .HasMaxLength(11)
            .IsRequired(false);


        builder
            .Property(x => x.Name)
            .HasMaxLength(145)
            .IsRequired(false);
    }
}