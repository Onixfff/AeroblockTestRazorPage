using System.ComponentModel.DataAnnotations.Schema;

namespace Aeroblock.DataAccess.Rail.Models
{
	[Table("vagon_costumerss")]
	//[Table("vagon_costumers")]
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