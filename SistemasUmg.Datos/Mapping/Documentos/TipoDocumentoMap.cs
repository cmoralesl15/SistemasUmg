using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemasUmg.Entidades.Documentos;

namespace SistemasUmg.Datos.Mapping.Documentos
{
    public class TipoDocumentoMap : IEntityTypeConfiguration<TipoDocumento>
    {
        public void Configure(EntityTypeBuilder<TipoDocumento> builder)
        {
            builder.ToTable("TipoDocumento")
                .HasKey(x => x.idTipoDocumento);
            builder.Property(x => x.nombre)
                .HasMaxLength(50);

            builder.HasOne(x => x.Documento);
        }
    }
}
