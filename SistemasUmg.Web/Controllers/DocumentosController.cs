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
    public class DocumentosController : ControllerBase
    {
        private readonly DbContextSistema _context;

        public DocumentosController(DbContextSistema context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Documento>>> GetDocumentos()
        {
            return await _context.Documentos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Documento>> GetDocumento(int id)
        {
            var documento = await _context.Documentos.FindAsync(id);

            if (documento == null)
            {
                return NotFound();
            }

            return documento;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDocumento(int id, Documento documento)
        {
            if (id != documento.idDocumento)
            {
                return BadRequest();
            }

            _context.Entry(documento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DocumentoExists(id))
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
        public async Task<ActionResult<Documento>> PostDocumento(Documento documento)
        {
            _context.Documentos.Add(documento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDocumento", new { id = documento.idDocumento }, documento);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Documento>> DeleteDocumento(int id)
        {
            var documento = await _context.Documentos.FindAsync(id);
            if (documento == null)
            {
                return NotFound();
            }

            _context.Documentos.Remove(documento);
            await _context.SaveChangesAsync();

            return documento;
        }

        private bool DocumentoExists(int id)
        {
            return _context.Documentos.Any(e => e.idDocumento == id);
        }
    }
}
