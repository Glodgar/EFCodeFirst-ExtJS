using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp.API.DTOs
{
    public class RezerwacjaDTO
    {
        public int KodRezerwacji { get; set; }
        public DateTime DataUtworzenia { get; set; }
        public float Cena { get; set; }
        public DateTime DataZameldowania { get; set; }
        public DateTime DataWymeldowania { get; set; }
        public string Waluta { get; set; }
        public int Id { get; set; }
        public float Prowizja { get; set; }
        public string Zrodlo { get; set; }
        public virtual List<GoscDTO> Goscie { get; set; }
    }
}
