namespace SGI.Models.Usuarios
{
    public class UsuarioModel : baseModel
    {
        public string nombre { get; set; } = string.Empty;
        public string nombreCompleto { get; set; } = string.Empty;
        public string correo { get; set; } = string.Empty;
        public string contraseña { get; set; } = string.Empty;
        public int id_Rol { get; set; } 
        public bool activo { get; set; }

        public RolModel rolModel { get; set; }
    }
}
