namespace SGI.Domain.Entities.Usuarios
{
    public class Rol 
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string? Descripcion { get; set; }
        public ICollection<Permiso> Permisos { get; set; } = new List<Permiso>();
    }
}
