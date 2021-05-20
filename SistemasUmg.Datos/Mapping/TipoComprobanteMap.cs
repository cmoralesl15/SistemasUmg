using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemasUmg.Entidades;

namespace SistemasUmg.Datos.Mapping
{
    public class TipoComprobanteMap : IEntityTypeConfiguration<TipoComprobante>
    {
        public void Configure(EntityTypeBuilder<TipoComprobante> builder)
        {
            builder.ToTable("TipoComprobante")
                .HasKey(x => x.idTipoComprobante);
            builder.Property(x => x.nombre)
                .HasMaxLength(50);
        }
    }
}
