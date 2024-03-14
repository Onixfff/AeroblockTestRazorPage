using Aeroblock.DataAccess.Rail.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class StationConfiguration : IEntityTypeConfiguration<StationEntity>
{
	public void Configure(EntityTypeBuilder<StationEntity> builder)
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

		builder
			.Property(x => x.Code)
			.HasMaxLength(10)
			.IsRequired(false);
	}
}