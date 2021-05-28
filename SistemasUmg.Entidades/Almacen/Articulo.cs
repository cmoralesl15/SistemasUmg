using System.ComponentModel.DataAnnotations;

namespace SistemasUmg.Entidades.Almacen
{
    public class Articulo
    {
        public int idArticulo { get; set; }
        public int idCategoria { get; set; }
        [StringLength(50, ErrorMessage = "Error: {0} debe tener una longitud máxima de {1}")]
        public string codigo { get; set; }
        [StringLength(50, ErrorMessage = "Error: {0} debe tener una longitud máxima de {1}")]
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public int stock { get; set; }
        [StringLength(256, ErrorMessage = "Error: {0} debe tener una longitud máxima de {1}")]
        public string descripcion { get; set; }
        public bool condicion { get; set; }
    }
}
