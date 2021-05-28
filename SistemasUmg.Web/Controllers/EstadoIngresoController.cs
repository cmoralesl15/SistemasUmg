using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemasUmg.Datos;
using SistemasUmg.Entidades.Compras;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemasUmg.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoIngresosController : ControllerBase
    {
        private readonly DbContextSistema _context;

        public EstadoIngresosController(DbContextSistema context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstadoIngreso>>> GetEstadoIngresos()
        {
            return await _context.EstadoIngresos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EstadoIngreso>> GetEstadoIngreso(int id)
        {
            var estadoIngreso = await _context.EstadoIngresos.FindAsync(id);

            if (estadoIngreso == null)
            {
                return NotFound();
            }

            return estadoIngreso;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstadoIngreso(int id, EstadoIngreso estadoIngreso)
        {
            if (id != estadoIngreso.idEstadoIngreso)
            {
                return BadRequest();
            }

            _context.Entry(estadoIngreso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstadoIngresoExists(id))
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

        [HttpPost]
        public async Task<ActionResult<EstadoIngreso>> PostEstadoIngreso(EstadoIngreso estadoIngreso)
        {
            _context.EstadoIngresos.Add(estadoIngreso);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEstadoIngreso", new { id = estadoIngreso.idEstadoIngreso }, estadoIngreso);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<EstadoIngreso>> DeleteEstadoIngreso(int id)
        {
            var estadoIngreso = await _context.EstadoIngresos.FindAsync(id);
            if (estadoIngreso == null)
            {
                return NotFound();
            }

            _context.EstadoIngresos.Remove(estadoIngreso);
            await _context.SaveChangesAsync();

            return estadoIngreso;
        }

        private bool EstadoIngresoExists(int id)
        {
            return _context.EstadoIngresos.Any(e => e.idEstadoIngreso == id);
        }
    }
}
