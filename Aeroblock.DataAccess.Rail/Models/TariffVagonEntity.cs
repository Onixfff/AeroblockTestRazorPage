using System.ComponentModel.DataAnnotations.Schema;

namespace Aeroblock.DataAccess.Rail.Models
{
#if DEBUG
	[Table("tariff_vagon")]
#else
	[Table("tariff_vagons")]
#endif

	public class TariffVagonEntity
	{
		[Column("id")]
		public int Id { get; set; } = 0;

		[Column("station")]
		public string? Station { get; set; } = string.Empty;

		[Column("tarif_full_to_kaliningrad_rf")]
		public float? tarif_full_to_kaliningrad_rf { get; set; } = 0;

		[Column("nds_tarif_full_to_kaliningrad")]
		public bool? nds_tarif_full_to_kaliningrad { get; set; }

		[Column("tarif_empty_from_kaliningrad_rf")]
		public float? tarif_empty_from_kaliningrad_rf { get; set; } = 0;

		[Column("nds_tarif_empty_from_kaliningrad_rf")]
		public bool? nds_tarif_empty_from_kaliningrad_rf { get; set; } = false;

		[Column("tarif_full_to_kaliningrad_by")]
		public float? tarif_full_to_kaliningrad_by { get; set; } = 0;

		[Column("nds_tarif_full_to_kaliningrad_by")]
		public bool? nds_tarif_full_to_kaliningrad_by { get; set; } = false;

		[Column("tarif_empty_from_kaliningrad_by")]
		public float? tarif_empty_from_kaliningrad_by { get; set; } = 0;

		[Column("nds_tarif_empty_from_kaliningrad_by")]
		public bool? nds_tarif_empty_from_kaliningrad_by { get; set; } = false;

		[Column("tarif_full_to_kaliningrad_lt")]
		public float? tarif_full_to_kaliningrad_lt { get; set; } = 0;

		[Column("nds_tarif_full_to_kaliningrad_lt")]
		public bool? nds_tarif_full_to_kaliningrad_lt { get; set; } = false;

		[Column("tarif_empty_from_kaliningrad_lt")]
		public float? tarif_empty_from_kaliningrad_lt { get; set; } = 0;

		[Column("nds_tarif_empty_from_kaliningrad_lt")]
		public bool? nds_tarif_empty_from_kaliningrad_lt { get; set; } = false;

		[Column("rent_vagon")]
		public float? rent_vagon { get; set; } = 0;

		[Column("nds_rent_vagon")]
		public bool? nds_rent_vagon { get; set; } = false;

		[Column("data")]
		public DateTime? data { get; set; } = DateTime.UtcNow;
	}
}