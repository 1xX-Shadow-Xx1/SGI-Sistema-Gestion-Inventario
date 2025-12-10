using SGI.Domain.Entities.Operacion;
using SGI.Domain.Enum;
using SGI.Models.Inventarios;

namespace SGI.Persistencia.Mappers.Inventarios
{
    public class MovimientoInventarioMapperModel
    {
        public static MovimientoInventario MapperMovimientoInventario(MovimientoInventarioModel model)
        {
            return new MovimientoInventario
            {
                ID = model.id_movimiento,
                Cantidad = model.cantidad,
                TipoMovimiento = (TipoMovimiento)model.tipo_movimiento,
                Fecha_movimiento = model.fecha_movimiento,
                Referencia = model.referencia,
                Producto = ProductoMapperModel.MapperProducto(model.productoModel)
            };
        }
        public static List<MovimientoInventario> MapperListMovimientoInventario(List<MovimientoInventarioModel> model)
        {
            List<MovimientoInventario> lista = new List<MovimientoInventario>();
            foreach (var item in model)
            {
                lista.Add(MapperMovimientoInventario(item));
            }
            return lista;
        }
        public static MovimientoInventarioModel MapperMovimientoInventarioModel(MovimientoInventario entity)
        {
            return new MovimientoInventarioModel
            {
                id_movimiento = entity.ID,
                cantidad = entity.Cantidad,
                tipo_movimiento = (int)entity.TipoMovimiento,
                fecha_movimiento = entity.Fecha_movimiento,
                referencia = entity.Referencia,
                productoModel = ProductoMapperModel.MapperProductoModel(entity.Producto),
                id_producto = entity.Producto.ID
            };
        }
        public static List<MovimientoInventarioModel> MapperListMovimientoInventarioModel(List<MovimientoInventario> entity)
        {
            List<MovimientoInventarioModel> lista = new List<MovimientoInventarioModel>();
            foreach (var item in entity)
            {
                lista.Add(MapperMovimientoInventarioModel(item));
            }
            return lista;
        }
    }
}
