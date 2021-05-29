using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemasUmg.Entidades.Compras
{
    public class EstadoIngreso
    {
        public int idEstadoIngreso { get; set; }
        [StringLength(50, ErrorMessage = "Error: {0} debe tener una longitud máxima de {1}")]
        public string nombre { get; set; }
        //Relaciones
        public virtual ICollection<Ingreso> Ingreso { get; set; }
    }
}
