using System.ComponentModel.DataAnnotations.Schema;

namespace Aeroblock.DataAccess.Rail.Models
{
    [Table("order_rzds")]
    //[Table("order_rzd")]
    public class OrderRzdEntity
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("date")]
        public DateOnly Date { get; set; }

        [Column("costumer")]
        public string Costumer { get; set; }

        [Column("material")]
        public string Material { get; set; }

        [Column("weight_1")]
        public string? Weight { get; set; } = string.Empty;

        [Column("col")]
        public int? Col { get; set; } = 0;

        [Column("sum_weight")]
        public int? SumWeight { get; set; } = 0;

        [Column("fact")]
        public int? Fact { get; set; } = 0;

        [Column("change_order")]
        public bool Order { get; set; }

        [Column("old")]
        public string Old { get; set; }

        [Column("comments")]
        public string Comment { get; set; }

        [Column("date_order")]
        public DateOnly DateOrder { get; set; }
    }
}