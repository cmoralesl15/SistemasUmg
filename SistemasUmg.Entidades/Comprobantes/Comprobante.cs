using System.ComponentModel.DataAnnotations;

namespace SistemasUmg.Entidades.Comprobantes
{
    public class Comprobante
    {
        public int idComprobante { get; set; }
        public int idTipoComprobante { get; set; }
        [StringLength(7, ErrorMessage = "Error: {0} debe tener una longitud máxima de {1}")]
        public string serie { get; set; }
        [StringLength(10, ErrorMessage = "Error: {0} debe tener una longitud máxima de {1}")]
        public string numero { get; set; }
    }
}
