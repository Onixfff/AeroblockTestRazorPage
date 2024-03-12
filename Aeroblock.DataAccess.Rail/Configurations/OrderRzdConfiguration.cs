using Aeroblock.DataAccess.Rail.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroblock.DataAccess.Rail.Configurations
{
    public class OrderRzdConfiguration : IEntityTypeConfiguration<OrderRzdEntity>
    {
        public void Configure(EntityTypeBuilder<OrderRzdEntity> builder)
        {
            builder
                .HasIndex(x => x.Id)
                .IsUnique(true);
            builder
                .Property(x => x.Id)
                .HasMaxLength(11)
                .IsRequired(true);

            builder
                .Property(x => x.Date)
                .HasColumnType("DATE")
                .IsRequired(true);

            builder
                .Property(x => x.Costumer)
                .HasMaxLength(125)
                .IsRequired(true);

            builder
                .Property(x => x.Material)
                .HasMaxLength(35)
                .IsRequired(true);

            builder
                .Property(x => x.Weight)
                .HasColumnType("FLOAT")
                .IsRequired(false);

            builder
                .Property(x => x.Col)
                .HasMaxLength(11)
                .IsRequired(false);

            builder
                .Property(x => x.SumWeight)
                .HasMaxLength(11)
                .IsRequired(false);

            builder
                .Property(x => x.Fact)
                .HasMaxLength(11)
                .IsRequired(false);

            builder
                .Property(x => x.Order)
                .HasMaxLength(1)
                .IsRequired(true);

            builder
                .Property(x => x.Old)
                .HasMaxLength(5)
                .IsRequired(true);

            builder
                .Property(x => x.Comment)
                .HasMaxLength(256)
                .IsRequired(true);

            builder
                .Property(x => x.DateOrder)
                .HasColumnType("DATE")
                .IsRequired(true);

        }
    }
}