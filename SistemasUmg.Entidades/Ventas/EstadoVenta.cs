using System.ComponentModel.DataAnnotations;

namespace SistemasUmg.Entidades.Ventas
{
    public class EstadoVenta
    {
        public int idEstadoVenta { get; set; }
        [StringLength(50, ErrorMessage = "Error: {0} debe tener una longitud máxima de {1}")]
        public string nombre { get; set; }
    }
}
