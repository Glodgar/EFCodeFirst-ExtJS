using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp.API.DTOs
{
    public class GoscDTO
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public string KodPocztowy { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Miasto { get; set; }
    }
}
