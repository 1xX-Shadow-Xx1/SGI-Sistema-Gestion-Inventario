using SGI.Domain.Entities.Usuarios;
using SGI.Models.Usuarios;

namespace SGI.Persistencia.Mappers.Usuarios
{
    public class PermisoMapperModel
    {
        public static Permiso MapperPermiso(PermisoModel model)
        {
            return new Permiso
            {
                ID = model.id_permiso,
                Nombre = model.nombre,
                Descripcion = model.descripcion,
                Roles = RolMapperModel.MapperListRol(model.rolModels)
            };
        }
        public static List<Permiso> MapperListPermiso(ICollection<PermisoModel> model)
        {
            List<Permiso> lista = new List<Permiso>();
            foreach (var item in model)
            {
                lista.Add(MapperPermiso(item));
            }
            return lista;
        }
        public static PermisoModel MapperPermisoModel(Permiso entity)
        {
            return new PermisoModel
            {
                id_permiso = entity.ID,
                nombre = entity.Nombre,
                descripcion = entity.Descripcion,
                rolModels = RolMapperModel.MapperListRolModel(entity.Roles)
            };
        }
        public static List<PermisoModel> MapperListPermisoModel(ICollection<Permiso> entity)
        {
            List<PermisoModel> lista = new List<PermisoModel>();
            foreach (var item in entity)
            {
                lista.Add(MapperPermisoModel(item));
            }
            return lista;
        }
    }
}
