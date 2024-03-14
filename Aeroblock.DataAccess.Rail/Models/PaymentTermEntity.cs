using System.ComponentModel.DataAnnotations.Schema;

namespace Aeroblock.DataAccess.Rail.Models
{
#if DEBUG
    [Table("payment_term")]
#else
    [Table("payment_terms")]
#endif

    public class PaymentTermEntity
    {
        [Column("id")]
        public int Id { get; set; } = 0;

        [Column("prepayment")]
        public int? Prepayment { get; set; } = 0;

        [Column("payment_final")]
        public int? PaymentFinal { get; set; } = 0;

        [Column("delay")]
        public int? Delay { get; set; } = 0;

        [Column("name")]
        public string? Name { get; set; } = string.Empty;

    }
}