using System.ComponentModel.DataAnnotations;

namespace SistemasUmg.Entidades.Usuarios
{
    public class Persona
    {
        public int idPersona { get; set; }
        public int idTipoPersona { get; set; }
        [StringLength(20, ErrorMessage = "Error: {0} debe tener una longitud máxima de {1}")]
        public string primerNombre { get; set; }
        [StringLength(20, ErrorMessage = "Error: {0} debe tener una longitud máxima de {1}")]
        public string segundoNombre { get; set; }
        [StringLength(20, ErrorMessage = "Error: {0} debe tener una longitud máxima de {1}")]
        public string primerApellido { get; set; }
        [StringLength(20, ErrorMessage = "Error: {0} debe tener una longitud máxima de {1}")]
        public string segundoApellido { get; set; }
        public int idDocumento { get; set; }
        [StringLength(70, ErrorMessage = "Error: {0} debe tener una longitud máxima de {1}")]
        public string direccion { get; set; }
        [StringLength(20, ErrorMessage = "Error: {0} debe tener una longitud máxima de {1}")]
        public string telefono { get; set; }
        [StringLength(50, ErrorMessage = "Error: {0} debe tener una longitud máxima de {1}")]
        public string email { get; set; }
    }
}
