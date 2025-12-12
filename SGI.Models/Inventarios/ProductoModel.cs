using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.Models.Inventarios
{
    [Table("Productos")]
    public class ProductoModel : baseModel
    {
        public string nombre { get; set; } = string.Empty;
        public decimal precio { get; set; } 
        public decimal impuesto { get; set; }
        public decimal? descuento { get; set; }
        public bool isAvailable { get; set; }
        public string? descripcion { get; set; } = string.Empty;
        public string? codigo_br { get; set; } = string.Empty;
        public string? url_img { get; set; } = string.Empty;
        public string? garantia { get; set; } = string.Empty;
        public string? marca { get; set; } = string.Empty;
    }
}
