namespace SGI.Appication.Dtos.Usuarios.RolDtos
{
    public class RolDto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string? Descripcion { get; set; }
        public ICollection<PermisoDto> PermisoDtos { get; set; } = new List<PermisoDto>();
    }
}
