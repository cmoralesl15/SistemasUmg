using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemasUmg.Entidades.Comprobantes;

namespace SistemasUmg.Datos.Mapping.Comprobantes
{
    public class ComprobanteMap : IEntityTypeConfiguration<Comprobante>
    {
        public void Configure(EntityTypeBuilder<Comprobante> builder)
        {
            builder.ToTable("Comprobante")
                .HasKey(x => x.idComprobante);
            builder.Property(x => x.idTipoComprobante);
            builder.Property(x => x.serie)
                .HasMaxLength(7);
            builder.Property(x => x.numero)
                .HasMaxLength(10);

            builder.HasOne(x => x.Ingreso);
            builder.HasOne(x => x.TipoComprobante);
            builder.HasOne(x => x.Venta);
        }
    }
}
