using SistemasUmg.Entidades.Almacen;

namespace SistemasUmg.Entidades.Compras
{
    public class DetalleIngreso
    {
        public int idDetalleIngreso { get; set; }
        public int idIngreso { get; set; }
        public int idArticulo { get; set; }
        public int cantidad { get; set; }
        public decimal total { get; set; }
        //Relaciones
        public virtual Articulo Articulo { get; set; }
        public virtual Ingreso Ingreso { get; set; }
    }
}
