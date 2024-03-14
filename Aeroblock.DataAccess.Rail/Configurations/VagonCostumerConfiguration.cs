using Aeroblock.DataAccess.Rail.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class VagonCostumerConfiguration : IEntityTypeConfiguration<VagonCostumerEntity>
{
	public void Configure(EntityTypeBuilder<VagonCostumerEntity> builder)
	{
		builder
			.HasIndex(x => x.Id)
			.IsUnique(true);
		builder
			.Property(x => x.Id)
			.IsRequired(true);

		builder
			.Property(x => x.Costumers)
			.HasMaxLength(245)
			.IsRequired(false);

		builder
			.Property(x => x.Adress)
			.HasMaxLength(245)
			.IsRequired(false);
	}
}