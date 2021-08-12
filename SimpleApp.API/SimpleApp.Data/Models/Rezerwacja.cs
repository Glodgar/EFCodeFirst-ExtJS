using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApp.Data.Models
{
    public class Rezerwacja
    {
        //Required
        public int KodRezerwacji { get; set; }
        public DateTime DataUtworzenia { get; set; }
        public float Cena { get; set; }
        public DateTime DataZameldowania { get; set; }
        public DateTime DataWymeldowania { get; set; }
        public string Waluta { get; set; }
        public int Id { get; set; }

        //Optional
        public float Prowizja { get; set; }
        public string Zrodlo { get; set; }

        public virtual List<Gosc> Goscie { get; set; }
    }
}
