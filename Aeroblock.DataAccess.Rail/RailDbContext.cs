using Aeroblock.DataAccess.Rail.Configurations;
using Aeroblock.DataAccess.Rail.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroblock.DataAccess.Rail
{
    public class RailDbContext : DbContext
    {
        public RailDbContext(DbContextOptions<RailDbContext> options)
            : base(options)
        {
        }
        builder.UseCollation("latin1_bin");
        public DbSet<VagonVihodEntity> VagonVihods { get; set; }
        public DbSet<OrderRzdEntity> OrderRzds { get; set; }
        public DbSet<CostumerEntity> Costumers { get; set; }
        public DbSet<CountryEntity> Countries {  get; set; }
        public DbSet<DeliveryTermEntity> DeliveryTerms {  get; set; }
        public DbSet<ManufacturerEntity> Manufacturers { get; set; }
        public DbSet<NameMaterialEntity> NameMaterials { get; set; }
        public DbSet<NdsEntity> Nds { get; set; }
        public DbSet<PaymentTermEntity> PaymentTerms { get; set; }
        public DbSet<SiloBalanceEntity> SiloBalances { get; set; }
        public DbSet<SkladEntity> sklads { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
			builder.UseCollation("latin1_bin");
			builder.ApplyConfiguration(new VagonVihodConfiguration());
            builder.ApplyConfiguration(new OrderRzdConfiguration());
            builder.ApplyConfiguration(new CostumerConfiguration());
            builder.ApplyConfiguration(new CountryConfiguration());
            builder.ApplyConfiguration(new DeliveryTermConfiguration());
            builder.ApplyConfiguration(new ManufacturerConfiguration());
            builder.ApplyConfiguration(new NameMaterialConfiguration());
            builder.ApplyConfiguration(new NdsConfiguration());
            builder.ApplyConfiguration(new PaymentTermConfiguration());
            builder.ApplyConfiguration(new SiloBalanceConfiguration());
            builder.ApplyConfiguration(new SkladConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
