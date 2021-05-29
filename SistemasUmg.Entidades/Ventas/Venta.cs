using SistemasUmg.Entidades.Comprobantes;
using SistemasUmg.Entidades.Usuarios;
using System.Collections.Generic;

namespace SistemasUmg.Entidades.Ventas
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
        //Relaciones
        public virtual Comprobante Comprobante { get; set; }
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }
        public virtual EstadoVenta EstadoVenta { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
