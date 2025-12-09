namespace SGI.Models.Inventarios
{
    public class InventarioModel : baseModel
    {
        public int id_inventario { get; set; }
        public int id_producto { get; set; }
        public int stock { get; set; }
    }
}
