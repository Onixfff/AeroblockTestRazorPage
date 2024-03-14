using Aeroblock.DataAccess.Rail.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class GroupMaterialConfiguration : IEntityTypeConfiguration<GroupMaterialEntity>
{
	public void Configure(EntityTypeBuilder<GroupMaterialEntity> builder)
	{
		builder
			.HasIndex(x => x.Id)
			.IsUnique(true);
		builder
			.Property(x => x.Id)
			.IsRequired(true);

		builder
			.Property(x => x.Name)
			.HasMaxLength(45)
			.IsRequired(false);
	}
}