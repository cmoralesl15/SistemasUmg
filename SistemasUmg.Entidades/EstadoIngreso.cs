using System.ComponentModel.DataAnnotations;

namespace SistemasUmg.Entidades
{
    public class EstadoIngreso
    {
        public int idEstadoIngreso { get; set; }
        [StringLength(50, ErrorMessage = "Error: {0} debe tener una longitud máxima de {1}")]
        public string nombre { get; set; }
    }
}
