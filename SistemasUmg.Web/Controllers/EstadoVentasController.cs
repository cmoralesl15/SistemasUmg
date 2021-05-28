using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemasUmg.Datos;
using SistemasUmg.Entidades.Ventas;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemasUmg.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoVentasController : ControllerBase
    {
        private readonly DbContextSistema _context;

        public EstadoVentasController(DbContextSistema context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstadoVenta>>> GetEstadoVentas()
        {
            return await _context.EstadoVentas.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EstadoVenta>> GetEstadoVenta(int id)
        {
            var estadoVenta = await _context.EstadoVentas.FindAsync(id);

            if (estadoVenta == null)
            {
                return NotFound();
            }

            return estadoVenta;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstadoVenta(int id, EstadoVenta estadoVenta)
        {
            if (id != estadoVenta.idEstadoVenta)
            {
                return BadRequest();
            }

            _context.Entry(estadoVenta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstadoVentaExists(id))
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
        public async Task<ActionResult<EstadoVenta>> PostEstadoVenta(EstadoVenta estadoVenta)
        {
            _context.EstadoVentas.Add(estadoVenta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEstadoVenta", new { id = estadoVenta.idEstadoVenta }, estadoVenta);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<EstadoVenta>> DeleteEstadoVenta(int id)
        {
            var estadoVenta = await _context.EstadoVentas.FindAsync(id);
            if (estadoVenta == null)
            {
                return NotFound();
            }

            _context.EstadoVentas.Remove(estadoVenta);
            await _context.SaveChangesAsync();

            return estadoVenta;
        }

        private bool EstadoVentaExists(int id)
        {
            return _context.EstadoVentas.Any(e => e.idEstadoVenta == id);
        }
    }
}
