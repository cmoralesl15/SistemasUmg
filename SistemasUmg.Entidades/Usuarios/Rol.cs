using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemasUmg.Entidades.Usuarios
{
    public class Rol
    {
        public int idRol { get; set; }
        [StringLength(50, ErrorMessage = "Error: {0} debe tener una longitud m?xima de {1}")]
        public string nombre { get; set; }
        [StringLength(256, ErrorMessage = "Error: {0} debe tener una longitud m?xima de {1}")]
        public string descripcion { get; set; }
        public bool condicion { get; set; }
        //Relaciones
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
