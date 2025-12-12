using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.Models.Inventarios
{
    [Table("Inventario")]
    public class InventarioModel : baseModel
    {
        public int id_producto { get; set; }
        public int stock { get; set; }

        [ForeignKey("FK_Inventario_Productos")]
        public ProductoModel productoModel { get; set; }
    }
}
