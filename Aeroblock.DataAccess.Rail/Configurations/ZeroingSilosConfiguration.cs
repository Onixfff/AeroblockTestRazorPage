using Aeroblock.DataAccess.Rail.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ZeroingSilosConfiguration : IEntityTypeConfiguration<ZeroingSilosEntity>
{
	public void Configure(EntityTypeBuilder<ZeroingSilosEntity> builder)
	{
		builder
			.HasIndex(x => x.Id)
			.IsUnique(true);
		builder
			.Property(x => x.Id)
			.IsRequired(true);

		builder
			.Property(x => x.Date)
			.HasColumnType("DATETIME")
			.IsRequired(false);

		builder
			.Property(x => x.Weight)
			.HasColumnType("float")
			.IsRequired(true);

		builder
			.Property(x => x.WeightSumIn)
			.HasColumnType("float")
			.IsRequired(true);

		builder
			.Property(x => x.WeightSumOut)
			.HasColumnType("float")
			.IsRequired(true);

		builder
			.Property(x => x.Material)
			.HasMaxLength(245)
			.IsRequired(false);

		builder
			.Property(e => e.SilosId)
			.IsRequired(true);

		builder.HasOne(x => x.SiloBalance)
			.WithMany()
			.HasForeignKey(x => x.SilosId);
	}
}