using SGI.Appication.Dtos.Inventarios.ProductoDtos;

namespace SGI.Appication.Dtos.Inventarios.InventarioDtos
{
    public class InventarioUpdateDto
    {
        public int Id { get; set; }
        public int? Cantidad { get; set; }
        public ProductoDto? ProductoDto { get; set; }
    }
}
