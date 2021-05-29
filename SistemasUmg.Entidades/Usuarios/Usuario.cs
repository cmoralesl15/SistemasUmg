using SistemasUmg.Entidades.Compras;
using SistemasUmg.Entidades.Documentos;
using SistemasUmg.Entidades.Ventas;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemasUmg.Entidades.Usuarios
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
        //Relaciones
        public virtual Documento Documento { get; set; }
        public virtual ICollection<Ingreso> Ingreso { get; set; }
        public virtual Rol Rol { get; set; }
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
