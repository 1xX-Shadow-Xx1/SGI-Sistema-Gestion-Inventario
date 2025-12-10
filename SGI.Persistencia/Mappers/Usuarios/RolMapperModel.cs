
using SGI.Domain.Entities.Usuarios;
using SGI.Models.Usuarios;

namespace SGI.Persistencia.Mappers.Usuarios
{
    public class RolMapperModel
    {
        public static Rol MapperRol(RolModel rol)
        {
            return new Rol
            {
                ID = rol.id_rol,
                Nombre = rol.nombre,
                Descripcion = rol.descripcion,
                Permisos = PermisoMapperModel.MapperListPermiso(rol.permisoModels)
            };
        }
        public static List<Rol> MapperListRol(ICollection<RolModel> rolesModel)
        {
            List<Rol> roles = new List<Rol>();
            foreach (var rolModel in rolesModel)
            {
                roles.Add(MapperRol(rolModel));
            }
            return roles;
        }
        public static RolModel MapperRolModel(Rol rol)
        {
            return new RolModel
            {
                id_rol = rol.ID,
                nombre = rol.Nombre,
                descripcion = rol.Descripcion,
                permisoModels = PermisoMapperModel.MapperListPermisoModel(rol.Permisos)
            };
        }
        public static List<RolModel> MapperListRolModel(ICollection<Rol> roles)
        {
            List<RolModel> rolesModel = new List<RolModel>();
            foreach (var rol in roles)
            {
                rolesModel.Add(MapperRolModel(rol));
            }
            return rolesModel;
        }
    }
}
