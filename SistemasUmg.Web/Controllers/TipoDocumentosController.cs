using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemasUmg.Datos;
using SistemasUmg.Entidades.Documentos;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemasUmg.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoDocumentosController : ControllerBase
    {
        private readonly DbContextSistema _context;

        public TipoDocumentosController(DbContextSistema context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoDocumento>>> GetTipoDocumentos()
        {
            return await _context.TipoDocumentos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TipoDocumento>> GetTipoDocumento(int id)
        {
            var tipoDocumento = await _context.TipoDocumentos.FindAsync(id);

            if (tipoDocumento == null)
            {
                return NotFound();
            }

            return tipoDocumento;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoDocumento(int id, TipoDocumento tipoDocumento)
        {
            if (id != tipoDocumento.idTipoDocumento)
            {
                return BadRequest();
            }

            _context.Entry(tipoDocumento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoDocumentoExists(id))
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
        public async Task<ActionResult<TipoDocumento>> PostTipoDocumento(TipoDocumento tipoDocumento)
        {
            _context.TipoDocumentos.Add(tipoDocumento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoDocumento", new { id = tipoDocumento.idTipoDocumento }, tipoDocumento);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TipoDocumento>> DeleteTipoDocumento(int id)
        {
            var tipoDocumento = await _context.TipoDocumentos.FindAsync(id);
            if (tipoDocumento == null)
            {
                return NotFound();
            }

            _context.TipoDocumentos.Remove(tipoDocumento);
            await _context.SaveChangesAsync();

            return tipoDocumento;
        }

        private bool TipoDocumentoExists(int id)
        {
            return _context.TipoDocumentos.Any(e => e.idTipoDocumento == id);
        }
    }
}
