using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aeroblock.DataAccess.Rail.Models
{
	//[Table("zeroing_silos")]
	[Table("zeroing_siloss")]
	public class ZeroingSilosEntity
	{
		[Column("id")]
		public int Id { get; set; } = 0;

		[Column("date")]
		public DateTime? Date { get; set; } = DateTime.UnixEpoch;

		[Column("weight")]
		public float Weight { get; set; } = float.MinValue;

		[Column("weight_sum_in")]
		public float WeightSumIn { get; set;} = float.MinValue;

		[Column("weight_sum_out")]
		public float WeightSumOut {  get; set;} = float.MinValue;

		[Column("material")]
		public string Material { get; set; } = string.Empty;

		[Column("id_silos")]
		public int? SilosId { get; set; }

		[ForeignKey("SilosId")]
		public SiloBalanceEntity? SiloBalance { get; set; }
	}
}