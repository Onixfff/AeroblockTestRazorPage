using Aeroblock.DataAccess.Rail.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroblock.DataAccess.Rail.Configurations
{
	public class VagonSendlerConfiguration : IEntityTypeConfiguration<VagonSendlerEntity>
    {
        public void Configure(EntityTypeBuilder<VagonSendlerEntity> builder)
        {
            builder
				.HasIndex(x => x.Id)
				.HasName("id_UNIQUE")
				.IsUnique(true);

            builder
				.Property(x => x.Id)
				.IsRequired(true);

            builder
				.Property(x => x.Sendler)
				.HasMaxLength(255)
				.IsRequired(false);
		}
    }
}