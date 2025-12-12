namespace SGI.Domain.Entities.Usuarios
{
    public class Permiso
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string? Descripcion { get; set; } 
        public ICollection<Rol> Roles { get; set; } = new List<Rol>(); 
    }
}
