using SGI.Domain.Entities.Inventarios;
using SGI.Models.Inventarios;

namespace SGI.Persistencia.Mappers.Inventarios
{
    public class ProductoMapperModel
    {
        public static Producto MapperProducto(ProductoModel model)
        {
            return new Producto
            {
                ID = model.ID,
                Nombre = model.nombre,
                Descripcion = model.descripcion,
                Precio = model.precio,
                IsAvailable = model.isAvailable,
                Codigo_Barra = model.codigo_br,
                Descuento = model.descuento,
                ITBIS = model.impuesto,
                Garantia = model.garantia,
                URL_Imagen = model.url_img,
                Fecha_creacion = model.Fecha_Creacion,
                Fecha_modificacion = model.Fecha_Modificacion,
                IsDeleted = model.IsDeleted
            };
        }
        public static List<Producto> MapperListProducto(List<ProductoModel> model)
        {
            List<Producto> lista = new List<Producto>();
            foreach (var item in model)
            {
                lista.Add(MapperProducto(item));
            }
            return lista;
        }
        public static ProductoModel MapperProductoModel(Producto entity)
        {
            return new ProductoModel
            {
                ID = entity.ID,
                nombre = entity.Nombre,
                descripcion = entity.Descripcion,
                precio = entity.Precio,
                isAvailable = entity.IsAvailable,
                codigo_br = entity.Codigo_Barra,
                descuento = entity.Descuento,
                impuesto = entity.ITBIS,
                garantia = entity.Garantia,
                url_img = entity.URL_Imagen,
                Fecha_Creacion = entity.Fecha_creacion,
                Fecha_Modificacion = entity.Fecha_modificacion,
                IsDeleted = entity.IsDeleted
            };
        }
        public static List<ProductoModel> MapperListProductoModel(List<Producto> entity)
        {
            List<ProductoModel> lista = new List<ProductoModel>();
            foreach (var item in entity)
            {
                lista.Add(MapperProductoModel(item));
            }
            return lista;
        }
    }
}
