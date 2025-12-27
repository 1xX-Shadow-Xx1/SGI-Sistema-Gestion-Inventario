using SGI.Appication.Dtos.Inventarios.InventarioDtos;

namespace SGI.Appication.Dtos.Inventarios.CatalogoDtos
{
    public class CatalogoCreateDto
    {
        public string Nombre { get; set; }
        public string? Descripcion { get; set; }
        public InventarioDto InventarioDto { get; set; }
    }
}
