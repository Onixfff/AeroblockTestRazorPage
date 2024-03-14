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
        public DbSet<SkladEntity> Sklads { get; set; }
        public DbSet<VagonSendlerEntity> VagonSendlers { get; set; }
        public DbSet<ValutaEntity> Valuta { get; set; }
        public DbSet<ZeroingSilosEntity> ZeroingSilos { get; set; }
        public DbSet<VagonMaterialEntity> VagonMaterials { get; set; }
        public DbSet<VagonCostumerEntity> VagonCostumers { get; set; }
        public DbSet<UnitEntity> Units { get; set; }
        public DbSet<TariffVagonEntity> TariffVagons { get; set; }
        public DbSet<StationEntity> Stations { get; set; }
        public DbSet<MoveSiloEntity> MoveSilos { get; set; }
        public DbSet<GroupMaterialEntity> GroupMaterials { get; set; }
        public DbSet<GeneralEntity> Generals { get; set; }


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
            builder.ApplyConfiguration(new VagonSendlerConfiguration());
            builder.ApplyConfiguration(new ValutaConfiguration());
            builder.ApplyConfiguration(new ZeroingSilosConfiguration());
            builder.ApplyConfiguration(new VagonMaterialConfiguration());
            builder.ApplyConfiguration(new VagonCostumerConfiguration());
            builder.ApplyConfiguration(new UnitConfiguration());
            builder.ApplyConfiguration(new TariffVagonConfiguration());
            builder.ApplyConfiguration(new StationConfiguration());
            builder.ApplyConfiguration(new MoveSiloConfiguration());
            builder.ApplyConfiguration(new GroupMaterialConfiguration());
            builder.ApplyConfiguration(new GeneralConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
