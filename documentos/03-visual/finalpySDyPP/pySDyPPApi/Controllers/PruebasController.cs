using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pySDyPPApi.Data;
using pySDyPPApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace cpySDyPPApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PruebasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PruebasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Prueba>>> GetPruebas()
        {
            return await _context.pruebas.ToListAsync();
        }

        [HttpGet("PorPaciente/{pacienteId}")]
        public async Task<ActionResult<IEnumerable<Prueba>>> GetPruebasPorPaciente(int pacienteId)
        {
            var pruebas = await _context.pruebas
                                        .Where(p => p.PacienteId == pacienteId)
                                        .ToListAsync();

            if (pruebas == null)
            {
                return NotFound();
            }

            return pruebas;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Prueba>> GetPrueba(int id)
        {
            var prueba = await _context.pruebas.FindAsync(id);
            if (prueba == null)
            {
                return NotFound();
            }
            return prueba;
        }

        [HttpPost]
        public async Task<ActionResult<Prueba>> CreatePrueba(Prueba newPrueba)
        {
            _context.pruebas.Add(newPrueba);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetPrueba), new { id = newPrueba.PruebaId }, newPrueba);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePrueba(int id, Prueba updatedPrueba)
        {
            if (id != updatedPrueba.PruebaId)
            {
                return BadRequest();
            }

            _context.Entry(updatedPrueba).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.pruebas.Any(p => p.PruebaId == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrueba(int id)
        {
            var prueba = await _context.pruebas.FindAsync(id);
            if (prueba == null)
            {
                return NotFound();
            }

            _context.pruebas.Remove(prueba);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}