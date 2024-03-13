using Aeroblock.DataAccess.Rail.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroblock.DataAccess.Rail.Configurations
{
    public class VagonVihodConfiguration : IEntityTypeConfiguration<VagonVihodEntity>
    {
        public void Configure(EntityTypeBuilder<VagonVihodEntity> builder)
        {
            builder
                .HasIndex(x => x.Id)
				.HasName("id_UNIQUE")
                .IsUnique(true);

            builder
                .Property(x => x.Id)
                .IsRequired(true);

            builder
                .Property(e => e.OrderId)
                .IsRequired(false);

            builder
                .Property(e => e.Number)
                .HasMaxLength(255)
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8")
                .IsRequired(true);

            builder
                .Property(e => e.Sender)
                .HasMaxLength(255)
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8")
                .IsRequired(false);

            builder
                .Property(e => e.Costumer)
                .HasMaxLength(255)
				.UseCollation("utf8_general_ci")
				.HasCharSet("utf8")
				.IsRequired(false);

            builder
                .Property(e => e.Date)
                .HasColumnType("DATETIME")
                .IsRequired(false);

            builder
                .Property(e => e.Material)
				.UseCollation("utf8_general_ci")
				.HasCharSet("utf8")
				.HasMaxLength(255);

            builder
                .Property(e => e.Prihod)
                .HasColumnType("DATETIME")
                .IsRequired(false);

            builder
                .Property(e => e.IsPrihod)
                .HasDefaultValue(false)
                .IsRequired(false);

            builder
                .Property(e => e.Partial)
                .HasMaxLength(45)
				.UseCollation("utf8_general_ci")
				.HasCharSet("utf8")
				.IsRequired(false);

            builder
                .Property(e => e.Start)
                .HasColumnType("DATETIME")
                .IsRequired(false);

            builder
                .Property(e => e.Finish)
                .HasColumnType("DATETIME")
                .IsRequired(false);

            builder
                .Property(e => e.IsStart)
                .HasDefaultValue(false)
                .IsRequired(false);

            builder
                .Property(e => e.IsStop)
                .HasDefaultValue(false)
                .IsRequired(false);

            builder
                .Property(e => e.NumberSilos)
                .HasMaxLength(45)
				.UseCollation("utf8_general_ci")
				.HasCharSet("utf8")
				.IsRequired(false);

            builder
                .Property(e => e.Time)
                .HasMaxLength(5)
                .UseCollation("latin1_swedish_ci")
                .HasCharSet(null)
				.IsRequired(false);

            builder
                .Property(e => e.VagonFinish)
                .HasColumnType("DATETIME")
                .IsRequired(false);

            builder
                .HasOne(e => e.Order)
                .WithMany()
                .HasForeignKey(e => e.OrderId);
        }
    }
}
