using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemasUmg.Entidades;

namespace SistemasUmg.Datos.Mapping
{
    public class TipoPersonaMap : IEntityTypeConfiguration<TipoPersona>
    {
        public void Configure(EntityTypeBuilder<TipoPersona> builder)
        {
            builder.ToTable("TipoPersona")
                .HasKey(x => x.idTipoPersona);
            builder.Property(x => x.nombre)
                .HasMaxLength(50);
        }
    }
}
