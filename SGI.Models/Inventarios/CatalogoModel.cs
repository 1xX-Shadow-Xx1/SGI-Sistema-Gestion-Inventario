

namespace SGI.Models.Inventarios
{
    public class CatalogoModel : baseModel
    {
        public string nombre { get; set; } = string.Empty;
        public string descripcion { get; set; } = string.Empty;
        public int id_inventario { get; set; }

        public InventarioModel inventarioModel { get; set; }
    }
}
