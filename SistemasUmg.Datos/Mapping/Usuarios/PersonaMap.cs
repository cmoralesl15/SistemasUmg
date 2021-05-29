using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemasUmg.Entidades.Usuarios;

namespace SistemasUmg.Datos.Mapping.Usuarios
{
    public class PersonaMap : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("Persona")
                .HasKey(x => x.idPersona);
            builder.Property(x => x.idTipoPersona);
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

            builder.HasOne(x => x.Documento);
            builder.HasOne(x => x.Ingreso);
            builder.HasOne(x => x.TipoPersona);
            builder.HasOne(x => x.Venta);
        }
    }
}
