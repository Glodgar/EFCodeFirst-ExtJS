using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApp.Data.Configuration
{
    public class GoscCfg : IEntityTypeConfiguration<Gosc>
    {
        public void Configure(EntityTypeBuilder<Gosc> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Imie).IsRequired();
            builder.Property(x => x.Nazwisko).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Id).IsRequired();
            builder.HasMany(x => x.Rezerwacje).WithMany(x => x.Goscie);
            
        }
    }
}
