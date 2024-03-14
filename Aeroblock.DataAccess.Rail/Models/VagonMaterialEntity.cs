using System.ComponentModel.DataAnnotations.Schema;

namespace Aeroblock.DataAccess.Rail.Models
{
	[Table("vagon_materials")]
	//[Table("vagon_material")]
	public class VagonMaterialEntity
	{
		[Column("id")]
		public int Id { get; set; } = 0;

		[Column("name")]
		public string? Material { get; set; } = string.Empty;
	}
}