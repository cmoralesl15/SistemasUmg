using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemasUmg.Entidades;

namespace SistemasUmg.Datos.Mapping
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria")
                .HasKey(x => x.idCategoria);
            builder.Property(x => x.nombre)
                .HasMaxLength(50);
            builder.Property(x => x.descripcion)
                .HasMaxLength(256);
        }
    }
}
