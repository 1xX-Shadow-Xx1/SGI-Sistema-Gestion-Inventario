using SGI.Appication.Dtos.Inventarios.ProductoDtos;

namespace SGI.Appication.Dtos.Inventarios.InventarioDtos
{
    public class InventarioDto : BaseDtos
    {
        public int Cantidad { get; set; }
        public ProductoDto ProductoDto { get; set; }
    }
}
