using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemasUmg.Entidades;

namespace SistemasUmg.Datos.Mapping
{
    public class DetalleIngresoMap : IEntityTypeConfiguration<DetalleIngreso>
    {
        public void Configure(EntityTypeBuilder<DetalleIngreso> builder)
        {
            builder.ToTable("DetalleIngreso")
                .HasKey(x => x.idDetalleIngreso);
            builder.Property(x => x.idIngreso);
            builder.Property(x => x.idArticulo);
            builder.Property(x => x.cantidad);
            builder.Property(x => x.total);
        }
    }
}
