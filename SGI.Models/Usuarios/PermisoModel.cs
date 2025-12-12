using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.Models.Usuarios
{
    [Table("Permisos")]
    public class PermisoModel
    {
        [Key]
        public int id_permiso { get; set; }
        public string nombre { get; set; } = string.Empty;
        public string? descripcion { get; set; } = string.Empty;

        [ForeignKey("FK_Permiso_Rol")]
        public ICollection<RolModel> rolModels { get; set; } = new List<RolModel>();
    }
}
