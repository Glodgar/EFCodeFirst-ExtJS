using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleApp.API.DTOs;
using SimpleApp.Data;
using SimpleApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RezerwacjeController : ControllerBase
    {
        private readonly IMapper _mapper;
        protected readonly AppDbContext _context;

        public RezerwacjeController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetRezerwacje()
        {
            var rezerwacje = _context.Rezerwacje.Include(g => g.Goscie);
            return Ok(rezerwacje);
        }

        [HttpPost]
        public async Task<IActionResult> AddRezerwacja([FromBody] RezerwacjaDTO rezerwacja)
        {
            var newRezerwacja = _mapper.Map<Rezerwacja>(rezerwacja);
            _context.Rezerwacje.Add(newRezerwacja);
            await _context.SaveChangesAsync();
            return Ok(newRezerwacja);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteRezerwacje()
        {
            var rezerwacje = _context.Rezerwacje;
            _context.Rezerwacje.RemoveRange(rezerwacje);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}

