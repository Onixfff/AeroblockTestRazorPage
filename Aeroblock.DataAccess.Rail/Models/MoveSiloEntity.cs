using System.ComponentModel.DataAnnotations.Schema;

namespace Aeroblock.DataAccess.Rail.Models
{
	[Table("move_silos")]
	//[Table("move_silo")]
	public class MoveSiloEntity
	{
		[Column("id")]
		public int Id { get; set; } = 0;

		[Column("timestamp")]
		public DateTime? Timestamp { get; set; } = DateTime.UtcNow;

		[Column("target_silo_id")]
		public int? target_silo_id { get; set; } = 0;

		[ForeignKey("target_silo_id")]
		public MoveSiloEntity? TargetMoveSilo { get; set; }

		[Column("target_silo_material")]
		public string? target_silo_material { get; set; } = string.Empty;

		[Column("target_silo_sendler")]
		public string? target_silo_sendler { get; set; } = string.Empty;

		[Column("source_silo_id")]
		public int? source_silo_id { get; set; } = 0;

		[ForeignKey("source_silo_id")]
		public MoveSiloEntity? SourceMoveSilo { get; set; }

		[Column("source_silo_material")]
		public string? source_silo_material { get; set; } = string.Empty;

		[Column("source_silo_sendler")]
		public string? source_silo_sendler { get; set; } = string.Empty;

		[Column("weight")]
		public float? weight { get; set; } = 0;


	}
}