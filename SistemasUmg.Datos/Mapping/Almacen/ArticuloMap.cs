using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemasUmg.Entidades.Almacen;

namespace SistemasUmg.Datos.Mapping.Almacen
{
    public class ArticuloMap : IEntityTypeConfiguration<Articulo>
    {
        public void Configure(EntityTypeBuilder<Articulo> builder)
        {
            builder.ToTable("Articulo")
                .HasKey(x => x.idArticulo);
            builder.Property(x => x.idCategoria);
            builder.Property(x => x.codigo)
                .HasMaxLength(50);
            builder.Property(x => x.nombre)
                .HasMaxLength(50);
            builder.Property(x => x.precio);
            builder.Property(x => x.stock);
            builder.Property(x => x.descripcion)
                .HasMaxLength(256);
            builder.Property(x => x.condicion);
        }
    }
}
