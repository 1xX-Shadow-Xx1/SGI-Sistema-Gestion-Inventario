namespace SGI.Domain.Base
{
    public abstract class baseEntity
    {
        public int ID { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime Fecha_creacion { get; set; } = DateTime.Now;
        public DateTime? Fecha_modificacion { get; set; }
    }
}
