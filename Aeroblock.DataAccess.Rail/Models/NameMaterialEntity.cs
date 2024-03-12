using System.ComponentModel.DataAnnotations.Schema;

namespace Aeroblock.DataAccess.Rail.Models
{
    [Table("name_material")]
    //[Table("country")]
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