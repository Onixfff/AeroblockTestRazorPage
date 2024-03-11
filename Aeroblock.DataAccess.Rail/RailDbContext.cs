﻿using Aeroblock.DataAccess.Rail.Configurations;
using Aeroblock.DataAccess.Rail.Models;
using Microsoft.EntityFrameworkCore;

namespace Aeroblock.DataAccess.Rail
{
    public class RailDbContext(DbContextOptions<RailDbContext> options)
        : DbContext(options)
    {
        public DbSet<OrderRzdEntity> OrderRzds { get; set; }
        public DbSet<VagonVihodEntity> VagonVihods { get; set; }

        public DbSet<CostumerEntity> CostumerEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VagonVihodConfiguration());
            modelBuilder.ApplyConfiguration(new OrderRzdConfiguration());
            modelBuilder.ApplyConfiguration(new CostumerConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
