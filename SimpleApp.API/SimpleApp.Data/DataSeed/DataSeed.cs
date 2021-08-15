using Microsoft.EntityFrameworkCore;
using SimpleApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleApp.Data.DataSeed
{
    public class DataSeed
    {
        
        private readonly AppDbContext _context;
        public DataSeed(AppDbContext context)
        {
            _context = context;
        }

        public void SeedData()
        {
            AddNewGosc(
                new Gosc 
                {
                    Imie = "Adam",
                    Nazwisko = "Adamowski",
                    Email = "adam.adamowski@gmail.com",

                });
            AddNewGosc(new Gosc 
                {
                    Imie = "Piotr",
                    Nazwisko = "Piotrowski",
                    Email = "piotr.piotrowski@gmail.com",
                    Miasto = "Wrocław",
                    Rezerwacje = new List<Rezerwacja>
                    {
                        new Rezerwacja
                        {
                            KodRezerwacji = 1,
                            DataUtworzenia = DateTime.Now,
                            Cena = 120,
                            DataZameldowania = DateTime.Now,
                            DataWymeldowania = DateTime.Now,
                            Waluta = "PLN",
                            Prowizja = 0,
                            Zrodlo = null,
                        }
                    }
            });
            AddNewGosc(new Gosc 
                {
                    Imie = "Piotr",
                    Nazwisko = "Piotrowski",
                    Email = "piotr.piotrowski@gmail.com",
                    Rezerwacje = new List<Rezerwacja>
                        {
                            new Rezerwacja
                            {
                                KodRezerwacji = 2,
                                DataUtworzenia = DateTime.Now,
                                Cena = 270,
                                DataZameldowania = DateTime.Now,
                                DataWymeldowania = DateTime.Now,
                                Waluta = "PLN",
                                Prowizja = 30,
                                Zrodlo = null,
                            }
                        }
            });
            AddNewGosc(new Gosc
                {
                    Imie = "Daniel",
                    Nazwisko = "Danielowski",
                    Email = "da.danie@gmail.com",
                    Miasto = "Wrocław",
                    Rezerwacje = new List<Rezerwacja>
                    {
                        new Rezerwacja 
                        {
                            KodRezerwacji = 3,
                            DataUtworzenia = DateTime.Now,
                            Cena = 350,
                            DataZameldowania = DateTime.Now,
                            DataWymeldowania = DateTime.Now,
                            Waluta = "PLN",
                            Prowizja = 20,
                            Zrodlo = null,
                        }
                    }
                }
            );

            _context.SaveChanges();
        }

        private void AddNewGosc(Gosc gosc)
        {
            var existingGosc = _context.Goscie.FirstOrDefault(p => p.Email == gosc.Email);
            if (existingGosc == null)
            {
                _context.Goscie.Add(gosc);
            }
        }

    }
}
