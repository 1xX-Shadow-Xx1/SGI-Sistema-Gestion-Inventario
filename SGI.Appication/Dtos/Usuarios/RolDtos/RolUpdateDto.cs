namespace SGI.Appication.Dtos.Usuarios.RolDtos
{
    public class RolUpdateDto
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public ICollection<PermisoDto>? PermisoDtos { get; set; } = new List<PermisoDto>();
    }
}
