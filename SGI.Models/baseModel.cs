using System.ComponentModel.DataAnnotations;

namespace SGI.Models
{
    public abstract class baseModel
    {
        [Key]
        public int id { get; set; }
        public bool isDeleted { get; set; }
        public DateTime fecha_creacion { get; set; } = DateTime.Now;
        public DateTime? fecha_modificacion { get; set; }
    }
}
