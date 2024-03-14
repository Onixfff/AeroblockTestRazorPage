using System.ComponentModel.DataAnnotations.Schema;

namespace Aeroblock.DataAccess.Rail.Models
{
    [Table("payment_terms")]
    //[Table("payment_term")]
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