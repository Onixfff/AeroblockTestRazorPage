using System.ComponentModel.DataAnnotations.Schema;

namespace Aeroblock.DataAccess.Rail.Models
{
#if DEBUG
	[Table("unit")]
#else
	[Table("units")]
#endif

	public class UnitEntity
	{
		[Column("id")]
		public int Id { get; set; } = 0;

		[Column("name")]
		public string? Name { get; set; } = string.Empty;
	}
}