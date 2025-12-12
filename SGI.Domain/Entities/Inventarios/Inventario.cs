using SGI.Domain.Base;

namespace SGI.Domain.Entities.Inventarios
{
    public class Inventario : baseEntity
    {
        public int Cantidad { get; set; }
        public Producto Producto { get; set; } 
    }
}
