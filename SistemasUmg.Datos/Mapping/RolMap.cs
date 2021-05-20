using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemasUmg.Entidades;

namespace SistemasUmg.Datos.Mapping
{
    public class RolMap : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.ToTable("Rol")
                .HasKey(x => x.idRol);
            builder.Property(x => x.nombre)
                .HasMaxLength(50);
            builder.Property(x => x.descripcion)
                .HasMaxLength(256);
            builder.Property(x => x.condicion);
        }
    }
}
