namespace SGI.Models
{
    public abstract class baseModel
    {
        public int ID { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Fecha_Creacion { get; set; } = DateTime.Now;
        public DateTime? Fecha_Modificacion { get; set; }
    }
}
