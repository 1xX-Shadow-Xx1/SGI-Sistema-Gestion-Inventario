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
                ID = model.ID,
                Nombre = model.nombre,
                Descripcion = model.descripcion,
                IsDeleted = model.IsDeleted,
                Fecha_creacion = model.Fecha_Creacion,
                Fecha_modificacion = model.Fecha_Modificacion,
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
                ID = entity.ID,
                nombre = entity.Nombre,
                descripcion = entity.Descripcion,
                IsDeleted = entity.IsDeleted,
                Fecha_Creacion = entity.Fecha_creacion,
                Fecha_Modificacion = entity.Fecha_modificacion,
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
