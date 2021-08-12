﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleApp.Data;

namespace SimpleApp.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GoscRezerwacja", b =>
                {
                    b.Property<int>("GoscieId")
                        .HasColumnType("int");

                    b.Property<int>("RezerwacjeId")
                        .HasColumnType("int");

                    b.HasKey("GoscieId", "RezerwacjeId");

                    b.HasIndex("RezerwacjeId");

                    b.ToTable("GoscRezerwacja");
                });

            modelBuilder.Entity("SimpleApp.Data.Models.Gosc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataUrodzenia")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KodPocztowy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Goscie");
                });

            modelBuilder.Entity("SimpleApp.Data.Models.Rezerwacja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Cena")
                        .HasColumnType("real");

                    b.Property<DateTime>("DataUtworzenia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataWymeldowania")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataZameldowania")
                        .HasColumnType("datetime2");

                    b.Property<int>("KodRezerwacji")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<float>("Prowizja")
                        .HasColumnType("real");

                    b.Property<string>("Waluta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zrodlo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rezerwacje");
                });

            modelBuilder.Entity("GoscRezerwacja", b =>
                {
                    b.HasOne("SimpleApp.Data.Models.Gosc", null)
                        .WithMany()
                        .HasForeignKey("GoscieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimpleApp.Data.Models.Rezerwacja", null)
                        .WithMany()
                        .HasForeignKey("RezerwacjeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
