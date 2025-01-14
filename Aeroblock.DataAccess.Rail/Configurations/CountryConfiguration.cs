﻿using Aeroblock.DataAccess.Rail.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Net;

public class CountryConfiguration : IEntityTypeConfiguration<CountryEntity>
{
    public void Configure(EntityTypeBuilder<CountryEntity> builder)
    {
        builder
            .HasIndex(x => x.Id)
            .IsUnique(true);
        builder
            .Property(x => x.Id)
            .HasMaxLength(11)
            .IsRequired(true);

        builder
            .Property(x => x.Name)
            .HasMaxLength(45)
            .IsRequired(false);
    }
}
