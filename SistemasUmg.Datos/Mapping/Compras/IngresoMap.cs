using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemasUmg.Entidades.Compras;

namespace SistemasUmg.Datos.Mapping.Compras
{
    public class IngresoMap : IEntityTypeConfiguration<Ingreso>
    {
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

            builder.HasOne(x => x.Comprobante);
            builder.HasOne(x => x.DetalleIngreso);
            builder.HasOne(x => x.EstadoIngreso);
            builder.HasOne(x => x.Persona);
            builder.HasOne(x => x.Usuario);
        }
    }
}
