using Microsoft.EntityFrameworkCore;
using SGI.Models.Inventarios;
using SGI.Models.Usuarios;

namespace SGI.Persistencia.Context
{
    public class SGIContext : DbContext
    {
        public SGIContext(DbContextOptions<SGIContext> options) : base(options) { }

        public SGIContext() { }

        // Inventarios
        public DbSet<CatalogoModel> Catalogo { get; set; }
        public DbSet<InventarioModel> Inventario { get; set; }
        public DbSet<MovimientoInventarioModel> MovimientoInventario { get; set; }
        public DbSet<ProductoModel> Producto { get; set; }

        // Usuarios
        public DbSet<UsuarioModel> Usuario { get; set; }
        public DbSet<RolModel> Rol { get; set; }
        public DbSet<PermisoModel> Permiso { get; set; }

    }
}
