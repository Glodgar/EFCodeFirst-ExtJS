using Microsoft.EntityFrameworkCore;
using SimpleApp.Data.DataSeed;
using SimpleApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SimpleApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Rezerwacja> Rezerwacje { get; set; }
        public DbSet<Gosc> Goscie { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
