

using SGI.Appication.Dtos.Usuarios.RolDtos;

namespace SGI.Appication.Dtos.Usuarios
{
    public class PermisoDto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string? Descripcion { get; set; }
        public ICollection<RolDto> RolDtos { get; set; } = new List<RolDto>();
    }
}
