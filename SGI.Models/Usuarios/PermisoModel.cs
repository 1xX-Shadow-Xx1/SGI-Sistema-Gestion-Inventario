namespace SGI.Models.Usuarios
{
    public class PermisoModel
    {
        public int id_permiso { get; set; }
        public string nombre { get; set; } = string.Empty;
        public string? descripcion { get; set; } = string.Empty;
    }
}
