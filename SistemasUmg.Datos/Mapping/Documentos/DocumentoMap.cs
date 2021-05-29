using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemasUmg.Entidades.Documentos;

namespace SistemasUmg.Datos.Mapping.Documentos
{
    public class DocumentoMap : IEntityTypeConfiguration<Documento>
    {
        public void Configure(EntityTypeBuilder<Documento> builder)
        {
            builder.ToTable("Documento")
                .HasKey(x => x.idDocumento);
            builder.Property(x => x.idTipoDocumento);
            builder.Property(x => x.numero)
                .HasMaxLength(20);

            builder.HasOne(x => x.Persona);
            builder.HasOne(x => x.TipoDocumento);
            builder.HasOne(x => x.Usuario);
        }
    }
}
