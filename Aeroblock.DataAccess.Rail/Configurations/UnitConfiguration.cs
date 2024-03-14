using Aeroblock.DataAccess.Rail.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class UnitConfiguration : IEntityTypeConfiguration<UnitEntity>
{
	public void Configure(EntityTypeBuilder<UnitEntity> builder)
	{
		builder
			.HasIndex(x => x.Id)
			.IsUnique(true);
		builder
			.Property(x => x.Id)
			.IsRequired(true);

		builder
			.Property(x => x.Name)
			.HasMaxLength(10)
			.IsRequired(true);
	}
}