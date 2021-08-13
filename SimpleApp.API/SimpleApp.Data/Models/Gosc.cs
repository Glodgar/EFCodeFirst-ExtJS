using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApp.Data.Models
{
    public class Gosc
    {
        //Required
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }

        //Optional
        public DateTime DataUrodzenia { get; set; }
        public string KodPocztowy { get; set; }

        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Miasto { get; set; }

        public virtual List<Rezerwacja> Rezerwacje { get; set; }
    }
}
