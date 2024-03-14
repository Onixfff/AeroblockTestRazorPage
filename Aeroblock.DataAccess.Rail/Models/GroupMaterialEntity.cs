using System.ComponentModel.DataAnnotations.Schema;

namespace Aeroblock.DataAccess.Rail.Models
{
#if DEBUG
	[Table("group_material")]
#else
	[Table("group_materials")]
#endif

	public class GroupMaterialEntity
	{
		[Column("id")]
		public int Id { get; set; } = 0;

		[Column("name")]
		public string? Name { get; set; } = string.Empty;
	}
}