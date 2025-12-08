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

    public class PacientesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PacientesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Paciente>>> GetPacientes()
        {
            return await _context.pacientes.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Paciente>> GetPaciente(int id)
        {
            var paciente = await _context.pacientes.FindAsync(id);
            if (paciente == null)
            {
                return NotFound();
            }
            return paciente;
        }

        [HttpPost]
        public async Task<ActionResult<Paciente>> CreatePaciente(Paciente newPaciente)
        {
            _context.pacientes.Add(newPaciente);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetPaciente), new { id = newPaciente.PacienteId }, newPaciente);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePaciente(int id, Paciente updatedPaciente)
        {
            if (id != updatedPaciente.PacienteId)
            {
                return BadRequest();
            }

            _context.Entry(updatedPaciente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.pacientes.Any(p => p.PacienteId == id))
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
        public async Task<IActionResult> DeletePaciente(int id)
        {
            var paciente = await _context.pacientes.FindAsync(id);
            if (paciente == null)
            {
                return NotFound();
            }

            _context.pacientes.Remove(paciente);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
