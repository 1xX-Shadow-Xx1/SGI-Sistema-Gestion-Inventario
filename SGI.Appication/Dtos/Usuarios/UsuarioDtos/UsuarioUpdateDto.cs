using SGI.Appication.Dtos.Usuarios.RolDtos;

namespace SGI.Appication.Dtos.Usuarios.UsuarioDtos
{
    public class UsuarioUpdateDto
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Empleado { get; set; }
        public string? Correo { get; set; }
        public string? Contraseña { get; set; }
        public bool? Activo { get; set; }
        public RolDto? RolDto { get; set; }
    }
}
