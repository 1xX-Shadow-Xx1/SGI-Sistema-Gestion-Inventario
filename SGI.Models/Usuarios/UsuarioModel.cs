using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.Models.Usuarios
{
    [Table("Usuarios")]
    public class UsuarioModel : baseModel
    {
        public string nombre { get; set; } = string.Empty;
        public string nombreCompleto { get; set; } = string.Empty;
        public string correo { get; set; } = string.Empty;
        [Column("conHash")]
        public string contraseña { get; set; } = string.Empty;
        public int id_Rol { get; set; } 
        public bool activo { get; set; }

        [ForeignKey("FK_Usuario_Rol")]
        public RolModel rolModel { get; set; }
    }
}
