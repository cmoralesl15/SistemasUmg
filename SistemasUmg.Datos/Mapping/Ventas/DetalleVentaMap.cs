using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemasUmg.Entidades.Ventas;

namespace SistemasUmg.Datos.Mapping.Ventas
{
    public class DetalleVentaMap : IEntityTypeConfiguration<DetalleVenta>
    {
        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            builder.ToTable("DetalleVenta")
                .HasKey(x => x.idDetalleVenta);
            builder.Property(x => x.idVenta);
            builder.Property(x => x.idArticulo);
            builder.Property(x => x.cantidad);
            builder.Property(x => x.total);
            builder.Property(x => x.descuento);
        }
    }
}
