using SistemasUmg.Entidades.Compras;
using SistemasUmg.Entidades.Ventas;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemasUmg.Entidades.Almacen
{
    public class Articulo
    {
        public int idArticulo { get; set; }
        public int idCategoria { get; set; }
        [StringLength(50, ErrorMessage = "Error: {0} debe tener una longitud máxima de {1}")]
        public string codigo { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Error: {0} debe tener una longitud máxima de {1}")]
        public string nombre { get; set; }
        [Required]
        public decimal precio { get; set; }
        [Required]
        public int stock { get; set; }
        [StringLength(256, ErrorMessage = "Error: {0} debe tener una longitud máxima de {1}")]
        public string descripcion { get; set; }
        public bool condicion { get; set; }
        //Relaciones
        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<DetalleIngreso> DetalleIngreso { get; set; }
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }
    }
}
