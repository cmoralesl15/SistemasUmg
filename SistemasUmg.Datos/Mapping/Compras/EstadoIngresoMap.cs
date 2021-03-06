using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemasUmg.Entidades.Compras;

namespace SistemasUmg.Datos.Mapping.Compras
{
    public class EstadoIngresoMap : IEntityTypeConfiguration<EstadoIngreso>
    {
        public void Configure(EntityTypeBuilder<EstadoIngreso> builder)
        {
            builder.ToTable("EstadoIngreso")
                .HasKey(x => x.idEstadoIngreso);
            builder.Property(x => x.nombre)
                .HasMaxLength(50);

            builder.HasOne(x => x.Ingreso);
        }
    }
}
