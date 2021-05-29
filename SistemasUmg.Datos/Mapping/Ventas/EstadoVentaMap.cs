using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemasUmg.Entidades.Ventas;

namespace SistemasUmg.Datos.Mapping.Ventas
{
    public class EstadoVentaMap : IEntityTypeConfiguration<EstadoVenta>
    {
        public void Configure(EntityTypeBuilder<EstadoVenta> builder)
        {
            builder.ToTable("EstadoVenta")
                .HasKey(x => x.idEstadoVenta);
            builder.Property(x => x.nombre)
                .HasMaxLength(50);

            builder.HasOne(x => x.Venta);
        }
    }
}
