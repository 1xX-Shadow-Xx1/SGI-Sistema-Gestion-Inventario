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
                ID = model.ID,
                Cantidad = model.stock,
                Fecha_creacion = model.Fecha_Creacion,
                Fecha_modificacion = model.Fecha_Modificacion,
                IsDeleted = model.IsDeleted,
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
                ID = entity.ID,
                stock = entity.Cantidad,
                Fecha_Creacion = entity.Fecha_creacion,
                Fecha_Modificacion = entity.Fecha_modificacion,
                IsDeleted = entity.IsDeleted,
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
