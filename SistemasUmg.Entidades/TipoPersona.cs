using System.ComponentModel.DataAnnotations;

namespace SistemasUmg.Entidades
{
    public class TipoPersona
    {
        public int idTipoPersona { get; set; }
        [StringLength(50, ErrorMessage = "Error: {0} debe tener una longitud m�xima de {1}")]
        public string nombre { get; set; }
    }
}
