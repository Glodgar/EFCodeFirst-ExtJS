using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApp.Data.Configuration
{
    public class RezerwacjaCfg : IEntityTypeConfiguration<Rezerwacja>
    {
        public void Configure(EntityTypeBuilder<Rezerwacja> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.KodRezerwacji).IsRequired().HasMaxLength(10);
            builder.Property(x => x.DataUtworzenia).IsRequired();
            builder.Property(x => x.Cena).IsRequired();
            builder.Property(x => x.DataZameldowania).IsRequired();
            builder.Property(x => x.DataWymeldowania).IsRequired();
            builder.Property(x => x.Waluta).IsRequired();
            builder.Property(x => x.Id).IsRequired();
            builder.HasMany(x => x.Goscie).WithMany(x => x.Rezerwacje);
        }

    }
}
