

using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.Models.Inventarios
{
    [Table("Catalogo")]
    public class CatalogoModel : baseModel
    {
        public string nombre { get; set; } = string.Empty;
        public string? descripcion { get; set; } = string.Empty;
        public int id_inventario { get; set; }

        [ForeignKey("FK_Catalogo_Inventario")]
        public InventarioModel inventarioModel { get; set; }
    }
}
