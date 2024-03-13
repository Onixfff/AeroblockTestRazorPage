using System.ComponentModel.DataAnnotations.Schema;

namespace Aeroblock.DataAccess.Rail.Models
{
	[Table("vagon_sendlers")]
	//[Table("vagon_sendler")]
	public class VagonSendlerEntity
	{
		[Column("id")]
		public int Id { get; set; } = 0;

		[Column("sendler")]
		public string? Sendler { get; set; } = string.Empty;
	}
}