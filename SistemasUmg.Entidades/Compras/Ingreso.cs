using SistemasUmg.Entidades.Comprobantes;
using SistemasUmg.Entidades.Usuarios;
using System.Collections.Generic;

namespace SistemasUmg.Entidades.Compras
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
        //Relaciones
        public virtual Comprobante Comprobante { get; set; }
        public virtual ICollection<DetalleIngreso> DetalleIngreso { get; set; }
        public virtual EstadoIngreso EstadoIngreso { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
