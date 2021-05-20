using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemasUmg.Entidades;

namespace SistemasUmg.Datos.Mapping
{
    public class IngresoMap : IEntityTypeConfiguration<Ingreso>
    {
        public int idIngreso { get; set; }
        public int idProveedor { get; set; }
        public int idUsuario { get; set; }
        public int idComprobante { get; set; }
        public System.DateTime fechaHora { get; set; }
        public decimal impuesto { get; set; }
        public decimal total { get; set; }
        public int idEstadoIngreso { get; set; }

        public void Configure(EntityTypeBuilder<Ingreso> builder)
        {
            builder.ToTable("Ingreso")
                .HasKey(x => x.idIngreso);
            builder.Property(x => x.idProveedor);
            builder.Property(x => x.idUsuario);
            builder.Property(x => x.idComprobante);
            builder.Property(x => x.fechaHora);
            builder.Property(x => x.impuesto);
            builder.Property(x => x.total);
            builder.Property(x => x.idEstadoIngreso);
        }
    }
}
