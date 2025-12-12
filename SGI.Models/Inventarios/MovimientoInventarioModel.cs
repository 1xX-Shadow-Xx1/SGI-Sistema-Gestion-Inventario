using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.Models.Inventarios
{
    [Table("MovementInventory")]
    public class MovimientoInventarioModel
    {
        [Key]
        public int id { get; set; }
        public int id_producto { get; set; }
        public int cantidad { get; set; }
        public DateTime fecha_movimiento { get; set; } = DateTime.Now;
        public int tipo_movimiento { get; set; } // "Entrada" o "Salida"
        public int? referencia { get; set; }

        [ForeignKey("FK_MovementInventory_Productos")]
        public ProductoModel productoModel { get; set; }
    }
}
