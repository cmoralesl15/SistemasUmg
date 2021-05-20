namespace SistemasUmg.Entidades
{
    public class DetalleVenta
    {
        public int idDetalleVenta { get; set; }
        public int idVenta { get; set; }
        public int idArticulo { get; set; }
        public int cantidad { get; set; }
        public decimal total { get; set; }
        public decimal descuento { get; set; }
    }
}
