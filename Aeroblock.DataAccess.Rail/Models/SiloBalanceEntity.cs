using System.ComponentModel.DataAnnotations.Schema;

namespace Aeroblock.DataAccess.Rail.Models
{
    //[Table("silo_balances")]
    [Table("silo_balance")]
    public class SiloBalanceEntity
    {
        [Column("id")]
        public int Id { get; set; } = 0;

        [Column("manufactur")]
        public string? Manufactur { get; set; } = string.Empty;

        [Column("silo_num")]
        public int? SiloNum { get; set; } = 0;

        [Column("silo_material_name")]
        public string? SiloMaterialName { get; set; } = string.Empty;

        [Column("silo_name_sendler")]
        public string? SiloNameSendler { get; set; } = string.Empty;

        [Column("weight")]
        public decimal? Weight { get; set; } = 0;

        [Column("max_weight")]
        public float? MaxWeight { get; set; } = 0;
    }
}