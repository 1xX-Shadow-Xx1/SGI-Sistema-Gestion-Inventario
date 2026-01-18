using SGI.Appication.Dtos.Inventarios.InventarioDtos;

namespace SGI.Appication.Dtos.Inventarios.CatalogoDtos
{
    public class CatalogoUpdateDto
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public bool IsDeleted { get; set; } = false;
        public InventarioDto? InventarioDto { get; set; }
    }
}
