
namespace SGI.Appication.Dtos
{
    public class BaseDtos
    {
        public int ID { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime Fecha_creacion { get; set; } = DateTime.Now;
        public DateTime? Fecha_modificacion { get; set; }
    }
}
