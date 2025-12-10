namespace SGI.Models.Inventarios
{
    public class InventarioModel : baseModel
    {
        public int id_producto { get; set; }
        public int stock { get; set; }

        public ProductoModel productoModel { get; set; }
    }
}
