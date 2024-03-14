using System.ComponentModel.DataAnnotations.Schema;

namespace Aeroblock.DataAccess.Rail.Models
{
#if DEBUG
	[Table("vagon_costumers")]
#else
[Table("vagon_costumerss")]
#endif

	public class VagonCostumerEntity
	{
		[Column("id")]
		public int Id { get; set; } = 0;

		[Column("costumers")]
		public string? Costumers { get; set; } = string.Empty;

		[Column("adress")]
		public string? Adress { get; set; } = string.Empty;
	}
}