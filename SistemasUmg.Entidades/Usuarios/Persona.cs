using SistemasUmg.Entidades.Compras;
using SistemasUmg.Entidades.Documentos;
using SistemasUmg.Entidades.Ventas;
using System.Collections.Generic;
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
        //Relaciones
        public virtual Documento Documento { get; set; }
        public virtual ICollection<Ingreso> Ingreso { get; set; }
        public virtual TipoPersona TipoPersona { get; set; }
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
