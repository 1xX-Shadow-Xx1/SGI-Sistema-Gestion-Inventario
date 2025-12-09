namespace SGI.Models
{
    public class baseModel
    {
        public bool IsDeleted { get; set; }
        public DateTime Fecha_Creacion { get; set; } = DateTime.Now;
        public DateTime? Fecha_Modificacion { get; set; }
    }
}
