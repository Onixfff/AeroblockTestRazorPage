using Aeroblock.DataAccess.Rail.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class VagonMaterialConfiguration : IEntityTypeConfiguration<VagonMaterialEntity>
{
	public void Configure(EntityTypeBuilder<VagonMaterialEntity> builder)
	{
		builder
			.HasIndex(x => x.Id)
			.IsUnique(true);
		builder
			.Property(x => x.Id)
			.IsRequired(true);

		builder
			.Property(x => x.Material)
			.HasMaxLength(45)
			.IsRequired(true);
	}
}