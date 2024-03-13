using System.ComponentModel.DataAnnotations.Schema;

namespace Aeroblock.DataAccess.Rail.Models
{
    //[Table("name_materials")]
    [Table("name_material")]
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