namespace AnalisisDeSistemas
{
    public class Venta
    {
        public int idVenta { get; set; }
        public int idCliente { get; set; }
        public int idUsuario { get; set; }
        public int idComprobante { get; set; }
        public System.DateTime fechaHora { get; set; }
        public decimal impuesto { get; set; }
        public decimal total { get; set; }
        public int idEstadoVenta { get; set; }
    }
}
