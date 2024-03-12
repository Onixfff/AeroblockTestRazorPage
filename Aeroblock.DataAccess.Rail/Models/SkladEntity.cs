﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Aeroblock.DataAccess.Rail.Models
{
    [Table("sklads")]
    //[Table("sklad")]
    public class SkladEntity
    {
        [Column("id")]
        public int Id { get; set; } = 0;

        [Column("name")]
        public string Name { get; set; } = string.Empty;

        [Column("name_material")]
        public string NameMaterial { get; set; } = string.Empty;
    }
}