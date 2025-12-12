using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.Models.Usuarios
{
    [Table("Roles")]
    public class RolModel
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; } = string.Empty;
        public string? descripcion { get; set; } = string.Empty;

        [ForeignKey("FK_Rol_Permiso")]
        public ICollection<PermisoModel> permisoModels { get; set; } = new List<PermisoModel>();
    }
}
