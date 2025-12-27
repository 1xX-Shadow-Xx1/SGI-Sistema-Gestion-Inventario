using SGI.Appication.Dtos.Inventarios.ProductoDtos;
using SGI.Domain.Enum;

namespace SGI.Appication.Dtos.Operacion
{
    public class MovimientoDto
    {
        public int ID { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha_movimiento { get; set; }
        public TipoMovimiento TipoMovimiento { get; set; } // "Entrada" o "Salida"
        public int? Referencia { get; set; }

        public ProductoDto ProductoDto { get; set; }
    }
}
