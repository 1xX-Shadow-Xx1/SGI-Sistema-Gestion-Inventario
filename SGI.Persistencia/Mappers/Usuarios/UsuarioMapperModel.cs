using SGI.Domain.Entities.Usuarios;
using SGI.Models.Usuarios;

namespace SGI.Persistencia.Mappers.Usuarios
{
    public class UsuarioMapperModel
    {
        public static UsuarioModel Create(Usuario usuario)
        {
            return new UsuarioModel
            {
                id_Rol = usuario.Rol.Id,
                nombre = usuario.Nombre,
                nombreCompleto = usuario.Empleado,
                correo = usuario.Correo,
                contraseña = usuario.Contraseña,
                activo = usuario.Activo,
                Fecha_Creacion = usuario.Fecha_creacion,
                IsDeleted = usuario.IsDeleted                
            };
        }
        public static UsuarioModel Update(Usuario usuario)
        {
            return new UsuarioModel
            {
                id_usuario = usuario.ID,
                id_Rol = usuario.Rol.Id,
                nombre = usuario.Nombre,
                nombreCompleto = usuario.Empleado,
                correo = usuario.Correo,
                contraseña = usuario.Contraseña,
                activo = usuario.Activo,
                Fecha_Creacion = usuario.Fecha_creacion,
                Fecha_Modificacion = usuario.Fecha_modificacion,
                IsDeleted = usuario.IsDeleted                
            };
        }
        public static UsuarioModel Remove(Usuario usuario)
        {
            return new UsuarioModel
            {
                id_usuario = usuario.ID,
                id_Rol = usuario.Rol.Id,
                nombre = usuario.Nombre,
                nombreCompleto = usuario.Empleado,
                correo = usuario.Correo,
                contraseña = usuario.Contraseña,
                activo = usuario.Activo,
                Fecha_Creacion = usuario.Fecha_creacion,
                Fecha_Modificacion = usuario.Fecha_modificacion,
                IsDeleted = true               
            };
        }
        public static List<Usuario> GetUser(List<UsuarioModel> usuariosModel)
        {
            List<Usuario> usuarios = new List<Usuario>();
            foreach (var usuarioModel in usuariosModel)
            {
                Usuario usuario = new Usuario
                {
                    ID = usuarioModel.id_usuario,
                    Nombre = usuarioModel.nombre,
                    Empleado = usuarioModel.nombreCompleto,
                    Correo = usuarioModel.correo,
                    Contraseña = usuarioModel.contraseña,
                    Activo = usuarioModel.activo,
                    Fecha_creacion = usuarioModel.Fecha_Creacion,
                    Fecha_modificacion = usuarioModel.Fecha_Modificacion,
                    IsDeleted = usuarioModel.IsDeleted,
                    Rol = new Rol
                    {
                        Id = usuarioModel.id_Rol
                    }
                };
                usuarios.Add(usuario);
            }
            return usuarios;
        }
        public static Usuario GetUser(UsuarioModel usuarioModel)
        {
            Usuario usuario = new Usuario
            {
                ID = usuarioModel.id_usuario,
                Nombre = usuarioModel.nombre,
                Empleado = usuarioModel.nombreCompleto,
                Correo = usuarioModel.correo,
                Contraseña = usuarioModel.contraseña,
                Activo = usuarioModel.activo,
                Fecha_creacion = usuarioModel.Fecha_Creacion,
                Fecha_modificacion = usuarioModel.Fecha_Modificacion,
                IsDeleted = usuarioModel.IsDeleted,
                Rol = new Rol
                {
                    Id = usuarioModel.id_Rol

                }
            };
            return usuario;
        }
        public static UsuarioModel Delete(Usuario usuario)
        {
            return new UsuarioModel
            {
                id_usuario = usuario.ID,
                id_Rol = usuario.Rol.Id,
                nombre = usuario.Nombre,
                nombreCompleto = usuario.Empleado,
                correo = usuario.Correo,
                contraseña = usuario.Contraseña,
                activo = usuario.Activo,
                Fecha_Creacion = usuario.Fecha_creacion,
                Fecha_Modificacion = usuario.Fecha_modificacion,
                IsDeleted = true                
            };
        }
    }
}
