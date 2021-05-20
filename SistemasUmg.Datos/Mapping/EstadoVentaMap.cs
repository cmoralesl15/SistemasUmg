using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemasUmg.Entidades;

namespace SistemasUmg.Datos.Mapping
{
    public class EstadoVentaMap : IEntityTypeConfiguration<EstadoVenta>
    {
        public void Configure(EntityTypeBuilder<EstadoVenta> builder)
        {
            builder.ToTable("EstadoVenta")
                .HasKey(x => x.idEstadoVenta);
            builder.Property(x => x.nombre)
                .HasMaxLength(50);
        }
    }
}
