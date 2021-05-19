namespace AnalisisDeSistemas
{
    public class Ingreso
    {
        public int idIngreso { get; set; }
        public int idProveedor { get; set; }
        public int idUsuario { get; set; }
        public int idComprobante { get; set; }
        public System.DateTime fechaHora { get; set; }
        public decimal impuesto { get; set; }
        public decimal total { get; set; }
        public int idEstadoIngreso { get; set; }
    }
}
