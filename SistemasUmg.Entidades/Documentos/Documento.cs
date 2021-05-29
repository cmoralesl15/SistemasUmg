using SistemasUmg.Entidades.Usuarios;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemasUmg.Entidades.Documentos
{
    public class Documento
    {
        public int idDocumento { get; set; }
        public int idTipoDocumento { get; set; }
        [StringLength(20, ErrorMessage = "Error: {0} debe tener una longitud máxima de {1}")]
        public string numero { get; set; }
        //Relaciones
        public virtual TipoDocumento TipoDocumento { get; set; }
        public virtual ICollection<Persona> Persona { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
