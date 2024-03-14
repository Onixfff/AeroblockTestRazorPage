using Aeroblock.DataAccess.Rail.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class MoveSiloConfiguration : IEntityTypeConfiguration<MoveSiloEntity>
{
	public void Configure(EntityTypeBuilder<MoveSiloEntity> builder)
	{
		builder
			.HasIndex(x => x.Id)
			.IsUnique(true);
		builder
			.Property(x => x.Id)
			.IsRequired(true);

		builder
			.Property(x => x.Timestamp)
			.HasColumnType("DATETIME")
			.IsRequired(false);

		builder
			.Property(x => x.target_silo_id)
			.IsRequired(false);

		builder
			.Property(x => x.target_silo_material)
			.HasMaxLength(256)
			.IsRequired(false);

		builder
			.Property(x => x.target_silo_sendler)
			.HasMaxLength(256)
			.IsRequired(false);

		builder
			.Property(x => x.source_silo_id)
			.IsRequired(false);

		builder
			.Property(x => x.source_silo_material)
			.HasMaxLength(256)
			.IsRequired(false);

		builder
			.Property(x => x.source_silo_sendler)
			.HasMaxLength(256)
			.IsRequired(false);

		builder
			.Property(x => x.weight)
			.HasColumnType("float")
			.IsRequired(false);

		builder
			.HasOne(x => x.TargetMoveSilo)
			.WithMany()
			.HasForeignKey(x => x.target_silo_id);

		builder
			.HasOne(x => x.SourceMoveSilo)
			.WithMany()
			.HasForeignKey(x => x.source_silo_id);
	}
}