﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aeroblock.DataAccess.Rail.Models
{
#if DEBUG
    [Table("vagon_vihod")]
#else
    [Table("vagon_vihods")]
#endif

    public class VagonVihodEntity
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("id_order")]
        public int? OrderId { get; set; }

        [ForeignKey("OrderId")]
        public OrderRzdEntity? Order { get; set; }

        [Column("number")]
        public string Number { get; set; } = string.Empty;

        [Column("sender")]
        public string? Sender { get; set; } = string.Empty;

        [Column("costumer")]
        public string? Costumer { get; set; } = string.Empty;

        [Column("date")]
        public DateTime? Date { get; set; } = DateTime.UnixEpoch;

        [Column("material")]
        public string Material { get; set; } = string.Empty;

        [Column("weight")]
        public int Weight { get; set; }

        [Column("data_prihod")]
        public DateTime? Prihod { get; set; } = DateTime.UnixEpoch;

        [Column("prihod")]
        public bool? IsPrihod { get; set; } = false;

        [Column("partia")]
        public string? Partial { get; set; } = string.Empty;

        [Column("data_start")]
        public DateTime? Start { get; set; } = DateTime.UnixEpoch;

        [Column("data_finish")]
        public DateTime? Finish { get; set; } = DateTime.UnixEpoch;

        [Column("status_start")]
        public bool? IsStart { get; set; } = false;

        [Column("status_stop")]
        public bool? IsStop { get; set; } = false;

        [Column("number_silos")]
        public string? NumberSilos { get; set; } = string.Empty;

        [Column("time")]
        public string? Time { get; set; } = string.Empty;

        [Column("vag_finish")]
        public DateTime? VagonFinish { get; set; } = DateTime.UnixEpoch;
    }
}