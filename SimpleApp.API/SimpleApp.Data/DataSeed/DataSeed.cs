using Microsoft.EntityFrameworkCore;
using SimpleApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApp.Data.DataSeed
{
    public static class DataSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gosc>().HasData(
                new Gosc
                {
                    Imie = "Adam",
                    Nazwisko = "Adamowski",
                    Email = "adam.adamowski@gmail.com",
                    Id = 1
                },
                new Gosc
                {
                    Imie = "Piotr",
                    Nazwisko = "Piotrowski",
                    Email = "piotr.piotrowski@gmail.com",
                    Id = 2
                },
                new Gosc
                {
                    Imie = "Bartosz",
                    Nazwisko = "Bartoszowski",
                    Email = "bartosz.bartoszowski@gmail.com",
                    Id = 3
                },
                new Gosc
                {
                    Imie = "Jacek",
                    Nazwisko = "Jackowski",
                    Email = "jacek.jackowski@gmail.com",
                    Id = 4,
                    Telefon = "123 456 789",
                    Adres = "ul. Jackowska 56",
                    Miasto = "Warszawa",
                }
            );

            modelBuilder.Entity<Rezerwacja>().HasData(
                new Rezerwacja
                {
                    KodRezerwacji = 1,
                    DataUtworzenia = DateTime.Now,
                    Cena = 120,
                    DataZameldowania = DateTime.Now,
                    DataWymeldowania = DateTime.Now,
                    Waluta = "PLN",
                    Id = 1,
                    Prowizja = 0,
                    Zrodlo = null,
                },
                new Rezerwacja
                {
                    KodRezerwacji = 2,
                    DataUtworzenia = DateTime.Now,
                    Cena = 150,
                    DataZameldowania = DateTime.Now,
                    DataWymeldowania = DateTime.Now,
                    Waluta = "PLN",
                    Id = 2,
                    Prowizja = 0,
                    Zrodlo = null,
                },
                new Rezerwacja
                {
                    KodRezerwacji = 3,
                    DataUtworzenia = DateTime.Now,
                    Cena = 170,
                    DataZameldowania = DateTime.Now,
                    DataWymeldowania = DateTime.Now,
                    Waluta = "PLN",
                    Id = 3,
                    Prowizja = 0,
                    Zrodlo = null,
                }
            );
        }
    }
}
