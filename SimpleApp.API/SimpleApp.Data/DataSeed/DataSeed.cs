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
            var Gosc1 = new Gosc
            {
                Imie = "Adam",
                Nazwisko = "Adamowski",
                Email = "adam.adamowski@gmail.com",
                Id = 1
            };

            var Gosc2 = new Gosc
            {
                Imie = "Piotr",
                Nazwisko = "Piotrowski",
                Email = "piotr.piotrowski@gmail.com",
                Id = 2,
                Miasto = "Wrocław"
            };

            var Gosc3 = new Gosc
            {
                Imie = "Piotr",
                Nazwisko = "Piotrowski",
                Email = "piotr.piotrowski@gmail.com",
                Id = 3
            };

            var Gosc4 = new Gosc
            {
                Imie = "Daniel",
                Nazwisko = "Danielowski",
                Email = "daniel.danielowski@gmail.com",
                Id = 4,
                Miasto = "Wrocław"
            };

            var Rezerwacja1 = new Rezerwacja
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
            };

            /*
            var GoscRezerwacja1 = new GoscRezerwacja
            {
                GoscId = Gosc1.Id,
                RezerwacjaId = Rezerwacja1.Id,
            };
            */

            modelBuilder.Entity<Gosc>().HasData(           
                Gosc1,
                Gosc2,
                Gosc3,
                Gosc4
            );
 

            modelBuilder.Entity<Rezerwacja>().HasData(
                Rezerwacja1
            );

            /*
            modelBuilder.Entity<GoscRezerwacja>().HasData(
                GoscRezerwacja1
            );
            */
        }
    }
}
