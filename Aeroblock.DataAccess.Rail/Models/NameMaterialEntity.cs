using System.ComponentModel.DataAnnotations.Schema;

namespace Aeroblock.DataAccess.Rail.Models
{
#if DEBUG
    [Table("name_material")]
#else
    [Table("name_materials")]
#endif

    public class NameMaterialEntity
    {
        [Column("id")]
        public int Id { get; set; } = 0;

        [Column("name")]
        public string? Name { get; set; } = string.Empty;

        [Column("group")]
        public string? Group { get; set; } = string.Empty;
    }
}