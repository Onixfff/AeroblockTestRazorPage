using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aeroblock.DataAccess.Rail.Models
{
	[Table("generals")]
	//[Table("general")]
	public class GeneralEntity
	{
		[Column("id")]
		public int Id { get; set; } = 0;

		[Column("id_order")]
		public int? OrderId { get; set; }

		[ForeignKey("OrderId")]
		public OrderRzdEntity? Order { get; set; }

		[Column("group")]
		public string? Group { get; set; } = string.Empty;

		[Column("name_material")]
		public string? NameMaterial { get; set; } = string.Empty;

		[Column("country")]
		public string? Country { get; set; } = string.Empty;

		[Column("manufakturer")]
		public string? Manufakturer { get; set; } = string.Empty;

		[Column("costumer")]
		public string? Costumer { get; set; } = string.Empty;

		[Column("delivery_term")]
		public string? DeliveryTerm { get; set; } = string.Empty;

		[Column("prise")]
		public float? Prise { get; set; } = 0;

		[Column("valuta")]
		public string? Valuta { get; set; } = string.Empty;

		[Column("nds")]
		public string? Nds { get; set; } = string.Empty;

		[Column("payment_term")]
		public string? PaymentTerm { get; set; } = string.Empty;

		[Column("party")]
		public float? Party { get; set; } = 0;

		[Column("tariff")]
		public int? Tariff { get; set; } = 0;

		[Column("RF")]
		public float? RF { get; set; } = 0;

		[Column("BY")]
		public float? BY { get; set; } = 0;

		[Column("LT")]
		public float? LT { get; set; } = 0;

		[Column("rent_vagon")]
		public float? RentVagon { get; set; } = 0;

		[Column("sum_not_NDS")]
		public float? SumNotNDS { get; set; } = 0;

		[Column("sum")]
		public float? Sum { get; set; } = 0;

		[Column("sum_NDS")]
		public float? SumNDS { get; set; } = 0;

		[Column("date")]
		public DateOnly? Date { get; set; } = DateOnly.MinValue;

		[Column("comments")]
		public string? Comments { get; set; } = string.Empty;

	}
}