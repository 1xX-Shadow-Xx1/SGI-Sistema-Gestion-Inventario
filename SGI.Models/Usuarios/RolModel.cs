namespace SGI.Models.Usuarios
{
    public class RolModel
    {
        public int id_rol { get; set; }
        public string nombre { get; set; } = string.Empty;
        public string? descripcion { get; set; } = string.Empty;

        public ICollection<PermisoModel> permisoModels { get; set; } = new List<PermisoModel>();
    }
}
