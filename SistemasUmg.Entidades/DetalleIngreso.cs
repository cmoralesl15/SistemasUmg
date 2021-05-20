namespace SistemasUmg.Entidades
{
    public class DetalleIngreso
    {
        public int idDetalleIngreso { get; set; }
        public int idIngreso { get; set; }
        public int idArticulo { get; set; }
        public int cantidad { get; set; }
        public decimal total { get; set; }
    }
}
