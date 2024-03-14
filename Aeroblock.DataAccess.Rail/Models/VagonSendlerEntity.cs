using System.ComponentModel.DataAnnotations.Schema;

namespace Aeroblock.DataAccess.Rail.Models
{
#if DEBUG
	[Table("vagon_sendler")]
#else
	[Table("vagon_sendlers")]
#endif

	public class VagonSendlerEntity
	{
		[Column("id")]
		public int Id { get; set; } = 0;

		[Column("sendler")]
		public string? Sendler { get; set; } = string.Empty;
	}
}