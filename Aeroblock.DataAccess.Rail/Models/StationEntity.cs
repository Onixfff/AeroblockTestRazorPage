using System.ComponentModel.DataAnnotations.Schema;

namespace Aeroblock.DataAccess.Rail.Models
{
#if DEBUG
	[Table("station")]
#else
	[Table("stations")]
#endif

	public class StationEntity
	{
		[Column("id")]
		public int Id { get; set; } = 0;

		[Column("name")]
		public string? Name { get; set; } = string.Empty;

		[Column("code")]
		public string? Code { get; set; } = string.Empty;
	}
}