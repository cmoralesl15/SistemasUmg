using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemasUmg.Entidades;

namespace SistemasUmg.Datos.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario")
                .HasKey(x => x.idUsuario);
            builder.Property(x => x.idRol);
            builder.Property(x => x.primerNombre)
                .HasMaxLength(20);
            builder.Property(x => x.segundoNombre)
                .HasMaxLength(20);
            builder.Property(x => x.primerApellido)
                .HasMaxLength(20);
            builder.Property(x => x.segundoApellido)
                .HasMaxLength(20);
            builder.Property(x => x.idDocumento);
            builder.Property(x => x.direccion)
                .HasMaxLength(70);
            builder.Property(x => x.telefono)
                .HasMaxLength(20);
            builder.Property(x => x.email)
                .HasMaxLength(50);
            builder.Property(x => x.passwordHash);
            builder.Property(x => x.passwordSal);
            builder.Property(x => x.condicion);
        }
    }
}
