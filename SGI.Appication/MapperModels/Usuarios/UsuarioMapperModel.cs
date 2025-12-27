using SGI.Domain.Entities.Usuarios;
using SGI.Models.Usuarios;
using SGI.Persistencia.Mappers.Usuarios;

namespace SGI.Persistencia.MapperModels.Usuarios
{
    public class UsuarioMapperModel
    {
        public static Usuario MapperUsuario(UsuarioModel model)
        {
            return new Usuario
            {
                ID = model.id,
                Nombre = model.nombre,
                Empleado = model.nombreCompleto,
                Correo = model.correo,
                Contraseña = model.contraseña,
                Activo = model.activo,
                Rol = RolMapperModel.MapperRol(model.rolModel),
                Fecha_creacion = model.fecha_creacion,
                Fecha_modificacion = model.fecha_modificacion,
                IsDeleted = model.isDeleted
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
                id = entity.ID,
                nombre = entity.Nombre,
                nombreCompleto = entity.Empleado,
                correo = entity.Correo,
                contraseña = entity.Contraseña,
                rolModel = RolMapperModel.MapperRolModel(entity.Rol),
                id_Rol = entity.Rol.ID,
                activo = entity.Activo,
                fecha_creacion = entity.Fecha_creacion,
                fecha_modificacion = entity.Fecha_modificacion,
                isDeleted = entity.IsDeleted
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