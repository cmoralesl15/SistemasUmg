using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemasUmg.Entidades;

namespace SistemasUmg.Datos.Mapping
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
        }
    }
}