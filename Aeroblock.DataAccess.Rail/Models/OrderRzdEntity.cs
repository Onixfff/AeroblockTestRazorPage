using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aeroblock.DataAccess.Rail.Models
{
    //[Table("order_rzds")]
    [Table("order_rzd")]
    public class OrderRzdEntity
    {
        [Column("id")]
        public int Id { get; set; } = 0;

        [Column("date")]
        public DateOnly Date { get; set; } = DateOnly.MinValue;

        [Column("costumer")]
        public string Costumer { get; set; } = string.Empty;

        [Column("material")]
        public string Material { get; set; } = string.Empty;

        [Column("weight_1")]
        public float? Weight { get; set; } = 0;

        [Column("col")]
        public int? Col { get; set; } = 0;

        [Column("sum_weight")]
        public int? SumWeight { get; set; } = 0;

        [Column("fact")]
        public int? Fact { get; set; } = 0;

        [Column("change_order")]
        public bool Order { get; set; } = false;

        [Column("old")]
        public string Old { get; set; } = string.Empty;

        [Column("comments")]
        public string Comment { get; set; } = string.Empty;

        [Column("date_order")]
        public DateOnly DateOrder { get; set; } = DateOnly.MinValue;
    }
}