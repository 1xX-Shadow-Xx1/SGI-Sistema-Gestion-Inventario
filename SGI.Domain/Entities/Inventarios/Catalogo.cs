using SGI.Domain.Base;

namespace SGI.Domain.Entities.Inventarios
{
    public class Catalogo : baseEntity
    {
        public string Nombre { get; set; }
        public string? Descripcion { get; set; }
        public Inventario Inventario { get; set; }
    }
}
