using SGI.Domain.Entities.Inventarios;
using SGI.Models.Inventarios;

namespace SGI.Persistencia.Mappers.Inventarios
{
    public class InventarioMapperModel
    {
        public static Inventario MapperInventario(InventarioModel model)
        {
            return new Inventario
            {
                ID = model.id,
                Cantidad = model.stock,
                Fecha_creacion = model.fecha_creacion,
                Fecha_modificacion = model.fecha_modificacion,
                IsDeleted = model.isDeleted,
                Producto = ProductoMapperModel.MapperProducto(model.productoModel)
            };
        }
        public static List<Inventario> MapperListInventario(List<InventarioModel> model)
        {
            List<Inventario> lista = new List<Inventario>();
            foreach (var item in model)
            {
                lista.Add(MapperInventario(item));
            }
            return lista;
        }
        public static InventarioModel MapperInventarioModel(Inventario entity)
        {
            return new InventarioModel
            {
                id = entity.ID,
                stock = entity.Cantidad,
                fecha_creacion = entity.Fecha_creacion,
                fecha_modificacion = entity.Fecha_modificacion,
                isDeleted = entity.IsDeleted,
                productoModel = ProductoMapperModel.MapperProductoModel(entity.Producto),
                id_producto = entity.Producto.ID
            };
        }
        public static List<InventarioModel> MapperListInventarioModel(List<Inventario> entity)
        {
            List<InventarioModel> lista = new List<InventarioModel>();
            foreach (var item in entity)
            {
                lista.Add(MapperInventarioModel(item));
            }
            return lista;
        }
    }
}
