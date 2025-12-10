using SGI.Domain.Entities.Usuarios;
using SGI.Models.Usuarios;

namespace SGI.Persistencia.Mappers.Usuarios
{
    public class UsuarioMapperModel
    {
        public static Usuario MapperUsuario(UsuarioModel model)
        {
            return new Usuario
            {
                ID = model.ID,
                Nombre = model.nombre,
                Empleado = model.nombreCompleto,
                Correo = model.correo,
                Contraseña = model.contraseña,
                Activo = model.activo,
                Rol = RolMapperModel.MapperRol(model.rolModel),
                Fecha_creacion = model.Fecha_Creacion,
                Fecha_modificacion = model.Fecha_Modificacion,
                IsDeleted = model.IsDeleted
            };
        }
        public static List<Usuario> MapperListUsuario(ICollection<UsuarioModel> model)
        {
            List<Usuario> lista = new List<Usuario>();
            foreach (var item in model)
            {
                lista.Add(MapperUsuario(item));
            }
            return lista;
        }
        public static UsuarioModel MapperUsuarioModel(Usuario entity)
        {
            return new UsuarioModel
            {
                ID = entity.ID,
                nombre = entity.Nombre,
                nombreCompleto = entity.Empleado,
                correo = entity.Correo,
                contraseña = entity.Contraseña,
                rolModel = RolMapperModel.MapperRolModel(entity.Rol),
                id_Rol = entity.Rol.ID,
                activo = entity.Activo,
                Fecha_Creacion = entity.Fecha_creacion,
                Fecha_Modificacion = entity.Fecha_modificacion,
                IsDeleted = entity.IsDeleted
            };
        }
        public static List<UsuarioModel> MapperListUsuarioModel(ICollection<Usuario> entity)
        {
            List<UsuarioModel> lista = new List<UsuarioModel>();
            foreach (var item in entity)
            {
                lista.Add(MapperUsuarioModel(item));
            }
            return lista;
        }
    }
}
