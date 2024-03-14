using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Aeroblock.DataAccess.Rail.Models
{
#if DEBUG
    [Table("country")]
#else
    [Table("countrys")]
#endif
    public class CountryEntity
    {
        [Column("id")]
        public int Id { get; set; } = 0;

        [Column("name")]
        public string? Name { get; set; } = string.Empty;
    }
}