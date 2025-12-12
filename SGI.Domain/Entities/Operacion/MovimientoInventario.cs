using SGI.Domain.Entities.Inventarios;
using SGI.Domain.Enum;

namespace SGI.Domain.Entities.Operacion
{
    public class MovimientoInventario
    {
        public int ID { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha_movimiento { get; set; }
        public TipoMovimiento TipoMovimiento { get; set; } // "Entrada" o "Salida"
        public int? Referencia { get; set; } 

        public Producto Producto { get; set; }
    }
}
