using Aeroblock.DataAccess.Rail.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class GeneralConfiguration : IEntityTypeConfiguration<GeneralEntity>
{
	public void Configure(EntityTypeBuilder<GeneralEntity> builder)
	{
		builder
			.HasIndex(x => x.Id)
			.IsUnique(true);
		builder
			.Property(x => x.Id)
			.IsRequired(true);

		builder
			.Property(x => x.OrderId)
			.IsRequired(true);

		builder
			.HasOne(x => x.Order)
			.WithMany()
			.HasForeignKey(x => x.OrderId);

		builder
			.Property(x => x.Group)
			.HasMaxLength(45)
			.IsRequired(false);

		builder
			.Property(x => x.NameMaterial)
			.HasMaxLength(45)
			.IsRequired(false);


		builder
			.Property(x => x.Country)
			.HasMaxLength(45)
			.IsRequired(false);

		builder
			.Property(x => x.Manufakturer)
			.HasMaxLength(145)
			.IsRequired(false);

		builder
			.Property(x => x.Costumer)
			.HasMaxLength(145)
			.IsRequired(false);

		builder
			.Property(x => x.DeliveryTerm)
			.HasMaxLength(145)
			.IsRequired(false);


		builder
			.Property(x => x.Prise)
			.HasColumnType("float")
			.IsRequired(false);


		builder
			.Property(x => x.Valuta)
			.HasMaxLength(10)
			.IsRequired(false);


		builder
			.Property(x => x.Nds)
			.HasMaxLength(50)
			.IsRequired(true);

		builder
			.Property(x => x.PaymentTerm)
			.HasMaxLength(145)
			.IsRequired(false);

		builder
			.Property(x => x.Party)
			.HasColumnType("float")
			.IsRequired(false);

		builder
			.Property(x => x.Tariff)
			.IsRequired(false);

		builder
			.Property(x => x.RF)
			.HasColumnType("float")
			.IsRequired(false);

		builder
			.Property(x => x.BY)
			.HasColumnType("float")
			.IsRequired(false);
			
		builder
			.Property(x => x.LT)
			.HasColumnType("float")
			.IsRequired(false);

		builder
			.Property(x => x.RentVagon)
			.HasColumnType("float")
			.IsRequired(false);

		builder
			.Property(x => x.SumNotNDS)
			.HasColumnType("float")
			.IsRequired(false);
						
		builder
			.Property(x => x.Sum)
			.HasColumnType("float")
			.IsRequired(false);

		builder
			.Property(x => x.SumNDS)
			.HasColumnType("float")
			.IsRequired(false);

		builder
			.Property(x => x.Date)
			.HasColumnType("DATE")
			.IsRequired(true);

		builder
			.Property(x => x.Comments)
			.HasMaxLength(245)
			.IsRequired(false);
	}
}
