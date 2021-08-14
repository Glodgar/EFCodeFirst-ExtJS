using AutoMapper;
using SimpleApp.API.DTOs;
using SimpleApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp.API.Mapping
{
    public class Configuration : Profile
    {
        public Configuration()
        {
            CreateMap<Rezerwacja, RezerwacjaDTO>().ReverseMap();
            CreateMap<Gosc, GoscDTO>().ReverseMap();
        }
    }
}
