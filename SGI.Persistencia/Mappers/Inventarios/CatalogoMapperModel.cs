using SGI.Domain.Entities.Inventarios;
using SGI.Models.Inventarios;

namespace SGI.Persistencia.Mappers.Inventarios
{
    public class CatalogoMapperModel
    {
        public static Catalogo MapperCatalogo(CatalogoModel model)
        {
            return new Catalogo
            {
                ID = model.id,
                Nombre = model.nombre,
                Descripcion = model.descripcion,
                IsDeleted = model.isDeleted,
                Fecha_creacion = model.fecha_creacion,
                Fecha_modificacion = model.fecha_modificacion,
                Inventario = InventarioMapperModel.MapperInventario(model.inventarioModel)
            };
        }
        public static List<Catalogo> MapperListCatalogo(List<CatalogoModel> model)
        {
            List<Catalogo> lista = new List<Catalogo>();
            foreach (var item in model)
            {
                lista.Add(MapperCatalogo(item));
            }
            return lista;
        }
        public static CatalogoModel MapperCatalogoModel(Catalogo entity)
        {
            return new CatalogoModel
            {
                id = entity.ID,
                nombre = entity.Nombre,
                descripcion = entity.Descripcion,
                isDeleted = entity.IsDeleted,
                fecha_creacion = entity.Fecha_creacion,
                fecha_modificacion = entity.Fecha_modificacion,
                id_inventario = entity.Inventario.ID,
                inventarioModel = InventarioMapperModel.MapperInventarioModel(entity.Inventario)
            };
        }
        public static List<CatalogoModel> MapperListCatalogoModel(List<Catalogo> entity)
        {
            List<CatalogoModel> lista = new List<CatalogoModel>();
            foreach (var item in entity)
            {
                lista.Add(MapperCatalogoModel(item));
            }
            return lista;
        }
    }
}
