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
    public class DetalleVentasController : ControllerBase
    {
        private readonly DbContextSistema _context;

        public DetalleVentasController(DbContextSistema context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetalleVenta>>> GetDetalleVentas()
        {
            return await _context.DetalleVentas.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DetalleVenta>> GetDetalleVenta(int id)
        {
            var detalleVenta = await _context.DetalleVentas.FindAsync(id);

            if (detalleVenta == null)
            {
                return NotFound();
            }

            return detalleVenta;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetalleVenta(int id, DetalleVenta detalleVenta)
        {
            if (id != detalleVenta.idDetalleVenta)
            {
                return BadRequest();
            }

            _context.Entry(detalleVenta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetalleVentaExists(id))
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
        public async Task<ActionResult<DetalleVenta>> PostDetalleVenta(DetalleVenta detalleVenta)
        {
            _context.DetalleVentas.Add(detalleVenta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetalleVenta", new { id = detalleVenta.idDetalleVenta }, detalleVenta);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<DetalleVenta>> DeleteDetalleVenta(int id)
        {
            var detalleVenta = await _context.DetalleVentas.FindAsync(id);
            if (detalleVenta == null)
            {
                return NotFound();
            }

            _context.DetalleVentas.Remove(detalleVenta);
            await _context.SaveChangesAsync();

            return detalleVenta;
        }

        private bool DetalleVentaExists(int id)
        {
            return _context.DetalleVentas.Any(e => e.idDetalleVenta == id);
        }
    }
}
