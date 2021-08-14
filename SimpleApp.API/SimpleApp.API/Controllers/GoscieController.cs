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
    public class GoscieController : ControllerBase
    {
        private readonly IMapper _mapper;
        protected readonly AppDbContext _context;

        public GoscieController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteGoscie()
        {
            var goscie = _context.Goscie;
            _context.Goscie.RemoveRange(goscie);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("/{Id}")]
        public async Task<IActionResult> DeleteGosc(int Id)
        {
            var gosc = await _context.Goscie.FindAsync(Id);
            _context.Goscie.Remove(gosc);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("/deleteGoscieImieMiasto")]
        public async Task<IActionResult> DeleteGoscieImieMiasto()
        {
            var goscie = _context.Goscie.Where(Gosc => (Gosc.Imie == "Piotr" && Gosc.Miasto == "Wrocław") || (Gosc.Imie == "Piotr" && Gosc.Miasto == null));
            _context.Goscie.RemoveRange(goscie);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetGoscie()
        {
            var goscie = _context.Goscie;
            return Ok(goscie);
        }

        [HttpPost]
        public async Task<IActionResult> AddGoscie([FromBody] RezerwacjaDTO rezerwacja)
        {
            var newRezerwacja = _mapper.Map<Rezerwacja>(rezerwacja);
            _context.Rezerwacje.Add(newRezerwacja);
            await _context.SaveChangesAsync();
            return Ok(newRezerwacja);
        }
    }
}
