using Aeroblock.DataAccess.Rail.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class TariffVagonConfiguration : IEntityTypeConfiguration<TariffVagonEntity>
{
	public void Configure(EntityTypeBuilder<TariffVagonEntity> builder)
	{
		builder
			.HasIndex(x => x.Id)
			.IsUnique(true);
		builder
			.Property(x => x.Id)
			.IsRequired(true);

		builder
			.Property(x => x.Station)
			.HasMaxLength(60)
			.IsRequired(false);
		
		builder
			.Property(x => x.tarif_full_to_kaliningrad_rf)
			.HasColumnType("float")
			.IsRequired(false);

		builder
			.Property(x => x.nds_tarif_full_to_kaliningrad)
			.HasMaxLength(1)
			.IsRequired(false);

		builder
			.Property(x => x.tarif_empty_from_kaliningrad_rf)
			.HasColumnType("float")
			.IsRequired(false);

		builder
			.Property(x => x.nds_tarif_empty_from_kaliningrad_rf)
			.HasMaxLength(1)
			.IsRequired(false);

		builder
			.Property(x => x.tarif_full_to_kaliningrad_by)
			.HasColumnType("float")
			.IsRequired(false);

		builder
			.Property(x => x.nds_tarif_full_to_kaliningrad_by)
			.HasMaxLength(1)
			.IsRequired(false);
		
		builder
			.Property(x => x.tarif_empty_from_kaliningrad_by)
			.HasColumnType("float")
			.IsRequired(false);

		builder
			.Property(x => x.nds_tarif_empty_from_kaliningrad_by)
			.HasMaxLength(1)
			.IsRequired(false);

		builder
			.Property(x => x.tarif_full_to_kaliningrad_lt)
			.HasColumnType("float")
			.IsRequired(false);

		builder
			.Property(x => x.nds_tarif_full_to_kaliningrad_lt)
			.HasMaxLength(1)
			.IsRequired(false);

		builder
			.Property(x => x.tarif_empty_from_kaliningrad_lt)
			.HasColumnType("float")
			.IsRequired(false);

		builder
			.Property(x => x.nds_tarif_empty_from_kaliningrad_lt)
			.HasMaxLength(1)
			.IsRequired(false);

		builder
			.Property(x => x.rent_vagon)
			.HasColumnType("float")
			.IsRequired(false);

		builder
			.Property(x => x.nds_rent_vagon)
			.HasMaxLength(1)
			.IsRequired(false);

		builder
			.Property(x => x.data)
			.HasColumnType("DATETIME")
			.IsRequired(false);
	}
}