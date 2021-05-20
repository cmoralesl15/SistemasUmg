using System.ComponentModel.DataAnnotations;

namespace SistemasUmg.Entidades
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public int idRol { get; set; }
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
        public byte[] passwordHash { get; set; }
        public byte[] passwordSal { get; set; }
        public bool condicion { get; set; }
    }
}
