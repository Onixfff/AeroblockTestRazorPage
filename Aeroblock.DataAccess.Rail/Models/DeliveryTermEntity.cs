using System.ComponentModel.DataAnnotations.Schema;

namespace Aeroblock.DataAccess.Rail.Models
{
#if DEBUG
    [Table("delivery_term")]
#else
    [Table("delivery_terms")]
#endif

    public class DeliveryTermEntity
    {
        [Column("id")]
        public int Id { get; set; } = 0;

        [Column("name")]
        public string? Name { get; set; } = string.Empty;
    }
}