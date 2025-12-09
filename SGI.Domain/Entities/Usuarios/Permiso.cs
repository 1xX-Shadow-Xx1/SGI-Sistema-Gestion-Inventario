namespace SGI.Domain.Entities.Usuarios
{
    public class Permiso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Rol> Roles { get; set; } = new List<Rol>(); 
    }
}
