using SGI.Domain.Base;

namespace SGI.Domain.Entities.Usuarios
{
    public class Usuario : baseEntity
    {
        public string Nombre { get; set; }
        public string Empleado { get; set; }
        public string Correo { get; set; } 
        public string Contraseña { get; set; }
        public bool Activo { get; set; }
    }
}
