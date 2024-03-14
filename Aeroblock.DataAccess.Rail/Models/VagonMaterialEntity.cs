using System.ComponentModel.DataAnnotations.Schema;

namespace Aeroblock.DataAccess.Rail.Models
{
#if DEBUG
	[Table("vagon_material")]
#else
	[Table("vagon_materials")]
#endif

	public class VagonMaterialEntity
	{
		[Column("id")]
		public int Id { get; set; } = 0;

		[Column("name")]
		public string? Material { get; set; } = string.Empty;
	}
}