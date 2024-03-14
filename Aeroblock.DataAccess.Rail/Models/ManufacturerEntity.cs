using System.ComponentModel.DataAnnotations.Schema;

namespace Aeroblock.DataAccess.Rail.Models
{
#if DEBUG
    [Table("manufacturer")]
#else
    [Table("manufacturers")]
#endif

    public class ManufacturerEntity
    {
        [Column("id")]
        public int Id { get; set; } = 0;

        [Column("name")]
        public string? Name { get; set; } = string.Empty;

        [Column("adress")]
        public string Adress { get; set; } = string.Empty;

        [Column("tel")]
        public string Phone { get; set; } = string.Empty;

        [Column("e_mail")]
        public string Email { get; set; } = string.Empty;

        [Column("site")]
        public string Site { get; set; } = string.Empty;

        [Column("face")]
        public string Face { get; set; } = string.Empty;

        [Column("contact_face")]
        public string ContactFace { get; set; } = string.Empty;
    }
}