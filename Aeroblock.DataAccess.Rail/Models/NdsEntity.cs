using System.ComponentModel.DataAnnotations.Schema;

namespace Aeroblock.DataAccess.Rail.Models
{
#if DEBUG
    [Table("nds")]
#else
    [Table("ndss")]
#endif
    public class NdsEntity
    {
        [Column("id")]
        public int Id { get; set; } = 0;

        [Column("name")]
        public string? Name { get; set; } = string.Empty;
    }
}