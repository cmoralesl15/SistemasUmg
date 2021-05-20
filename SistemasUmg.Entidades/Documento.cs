using System.ComponentModel.DataAnnotations;

namespace SistemasUmg.Entidades
{
    public class Documento
    {
        public int idDocumento { get; set; }
        public int idTipoDocumento { get; set; }
        [StringLength(20, ErrorMessage = "Error: {0} debe tener una longitud máxima de {1}")]
        public string numero { get; set; }
    }
}
