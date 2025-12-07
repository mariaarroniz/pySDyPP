using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using controlDiabeticos.Data;
using controlDiabeticos.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace controlDiabeticos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class PacientesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PacientesController (AppDbContext context) 
        {
            _context = context;
        }

        public readonly List<Paciente> pacientes = new()
        {
            new Paciente
            {
                Id = 1,
                Telefono = "123456789",
                Nombre = "María",
                Apellidos = "Arróniz",
                Edad = 20,
                Genero = "Femenino",
                FechaNacimiento = new DateTime(2005, 1, 8),
                TipoDiabetes = "Tipo 2",
                AlteracionesTipoII = true
            },
            new Paciente
            {
                Id = 2,
                Nombre = "Nazaret",
                Apellidos = "Deras",
                Edad = 22,
                Genero = "Femenino",
                FechaNacimiento = new DateTime(2003, 3, 30),
                TipoDiabetes = "Tipo 1",
                AlteracionesTipoII = false
            }
        };

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
            return CreatedAtAction(nameof(GetPaciente), new { id = newPaciente.Id }, newPaciente);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePaciente(int id, Paciente updatedPaciente)
        {
            if (id != updatedPaciente.Id) 
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
                if (!_context.pacientes.Any(p => p.Id == id))
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
