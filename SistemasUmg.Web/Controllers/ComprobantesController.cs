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
    public class ComprobantesController : ControllerBase
    {
        private readonly DbContextSistema _context;

        public ComprobantesController(DbContextSistema context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Comprobante>>> GetComprobantes()
        {
            return await _context.Comprobantes.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Comprobante>> GetComprobante(int id)
        {
            var comprobante = await _context.Comprobantes.FindAsync(id);

            if (comprobante == null)
            {
                return NotFound();
            }

            return comprobante;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutComprobante(int id, Comprobante comprobante)
        {
            if (id != comprobante.idComprobante)
            {
                return BadRequest();
            }

            _context.Entry(comprobante).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComprobanteExists(id))
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
        public async Task<ActionResult<Comprobante>> PostComprobante(Comprobante comprobante)
        {
            _context.Comprobantes.Add(comprobante);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComprobante", new { id = comprobante.idComprobante }, comprobante);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Comprobante>> DeleteComprobante(int id)
        {
            var comprobante = await _context.Comprobantes.FindAsync(id);
            if (comprobante == null)
            {
                return NotFound();
            }

            _context.Comprobantes.Remove(comprobante);
            await _context.SaveChangesAsync();

            return comprobante;
        }

        private bool ComprobanteExists(int id)
        {
            return _context.Comprobantes.Any(e => e.idComprobante == id);
        }
    }
}
