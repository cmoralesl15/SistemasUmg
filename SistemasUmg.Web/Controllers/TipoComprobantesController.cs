using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemasUmg.Datos;
using SistemasUmg.Entidades.Comprobantes;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemasUmg.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoComprobantesController : ControllerBase
    {
        private readonly DbContextSistema _context;

        public TipoComprobantesController(DbContextSistema context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoComprobante>>> GetTipoComprobantes()
        {
            return await _context.TipoComprobantes.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TipoComprobante>> GetTipoComprobante(int id)
        {
            var tipoComprobante = await _context.TipoComprobantes.FindAsync(id);

            if (tipoComprobante == null)
            {
                return NotFound();
            }

            return tipoComprobante;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoComprobante(int id, TipoComprobante tipoComprobante)
        {
            if (id != tipoComprobante.idTipoComprobante)
            {
                return BadRequest();
            }

            _context.Entry(tipoComprobante).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoComprobanteExists(id))
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
        public async Task<ActionResult<TipoComprobante>> PostTipoComprobante(TipoComprobante tipoComprobante)
        {
            _context.TipoComprobantes.Add(tipoComprobante);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoComprobante", new { id = tipoComprobante.idTipoComprobante }, tipoComprobante);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TipoComprobante>> DeleteTipoComprobante(int id)
        {
            var tipoComprobante = await _context.TipoComprobantes.FindAsync(id);
            if (tipoComprobante == null)
            {
                return NotFound();
            }

            _context.TipoComprobantes.Remove(tipoComprobante);
            await _context.SaveChangesAsync();

            return tipoComprobante;
        }

        private bool TipoComprobanteExists(int id)
        {
            return _context.TipoComprobantes.Any(e => e.idTipoComprobante == id);
        }
    }
}
