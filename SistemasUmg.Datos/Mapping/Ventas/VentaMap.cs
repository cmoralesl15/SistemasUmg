using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemasUmg.Entidades.Ventas;

namespace SistemasUmg.Datos.Mapping.Ventas
{
    public class VentaMap : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            builder.ToTable("Venta")
                .HasKey(x => x.idVenta);
            builder.Property(x => x.idCliente);
            builder.Property(x => x.idUsuario);
            builder.Property(x => x.idComprobante);
            builder.Property(x => x.fechaHora);
            builder.Property(x => x.impuesto);
            builder.Property(x => x.total);
            builder.Property(x => x.idEstadoVenta);

            builder.HasOne(x => x.Comprobante);
            builder.HasOne(x => x.DetalleVenta);
            builder.HasOne(x => x.EstadoVenta);
            builder.HasOne(x => x.Persona);
            builder.HasOne(x => x.Usuario);
        }
    }
}
