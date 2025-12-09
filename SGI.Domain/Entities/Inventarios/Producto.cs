using SGI.Domain.Base;

namespace SGI.Domain.Entities.Inventarios
{
    public class Producto : baseEntity
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal ITBIS { get; set; }
        public decimal Descuento { get; set; }
        public bool IsAvailable { get; set; }
        public string URL_Imagen { get; set; }
        public string Codigo_Barra { get; set; }
        public bool IsDeleted { get; set; }
        public string? Garantia { get; set; }
    }
}
