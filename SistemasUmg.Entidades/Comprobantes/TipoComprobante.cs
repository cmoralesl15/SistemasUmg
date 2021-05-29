using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemasUmg.Entidades.Comprobantes
{
    public class TipoComprobante
    {
        public int idTipoComprobante { get; set; }
        [StringLength(50, ErrorMessage = "Error: {0} debe tener una longitud máxima de {1}")]
        public string nombre { get; set; }
        //Relaciones
        public virtual ICollection<Comprobante> Comprobante { get; set; }
    }
}
