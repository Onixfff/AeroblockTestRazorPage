using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aeroblock.DataAccess.Rail.Models
{
#if DEBUG
	[Table("valuta")]
#else
	[Table("valutas")]
#endif
	public class ValutaEntity
	{
		[Column("id")]
		public int Id { get; set; } = 0;

		[Column("name")]
		public string? Name { get; set; } = string.Empty;
	}
}