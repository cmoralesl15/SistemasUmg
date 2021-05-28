using Microsoft.EntityFrameworkCore;
using SistemasUmg.Datos.Mapping.Almacen;
using SistemasUmg.Datos.Mapping.Compras;
using SistemasUmg.Datos.Mapping.Comprobantes;
using SistemasUmg.Datos.Mapping.Documentos;
using SistemasUmg.Datos.Mapping.Usuarios;
using SistemasUmg.Datos.Mapping.Ventas;
using SistemasUmg.Entidades.Almacen;
using SistemasUmg.Entidades.Compras;
using SistemasUmg.Entidades.Comprobantes;
using SistemasUmg.Entidades.Documentos;
using SistemasUmg.Entidades.Usuarios;
using SistemasUmg.Entidades.Ventas;

namespace SistemasUmg.Datos
{
    public class DbContextSistema : DbContext
    {
        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Comprobante> Comprobantes { get; set; }
        public DbSet<DetalleIngreso> DetalleIngresos { get; set; }
        public DbSet<DetalleVenta> DetalleVentas { get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<EstadoIngreso> EstadoIngresos { get; set; }
        public DbSet<EstadoVenta> EstadoVentas { get; set; }
        public DbSet<Ingreso> Ingresos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<TipoComprobante> TipoComprobantes { get; set; }
        public DbSet<TipoPersona> TipoPersonas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ArticuloMap());
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new ComprobanteMap());
            modelBuilder.ApplyConfiguration(new DetalleIngresoMap());
            modelBuilder.ApplyConfiguration(new DetalleVentaMap());
            modelBuilder.ApplyConfiguration(new DocumentoMap());
            modelBuilder.ApplyConfiguration(new EstadoIngresoMap());
            modelBuilder.ApplyConfiguration(new EstadoVentaMap());
            modelBuilder.ApplyConfiguration(new IngresoMap());
            modelBuilder.ApplyConfiguration(new PersonaMap());
            modelBuilder.ApplyConfiguration(new RolMap());
            modelBuilder.ApplyConfiguration(new TipoComprobanteMap());
            modelBuilder.ApplyConfiguration(new TipoDocumentoMap());
            modelBuilder.ApplyConfiguration(new TipoPersonaMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new VentaMap());
        }
    }
}
