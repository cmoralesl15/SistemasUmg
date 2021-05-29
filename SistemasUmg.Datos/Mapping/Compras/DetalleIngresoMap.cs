using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemasUmg.Entidades.Compras;

namespace SistemasUmg.Datos.Mapping.Compras
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

            builder.HasOne(x => x.Articulo);
            builder.HasOne(x => x.Ingreso);
        }
    }
}
