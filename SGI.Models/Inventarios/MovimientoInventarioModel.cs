namespace SGI.Models.Inventarios
{
    public class MovimientoInventarioModel
    {
        public int id_movimiento { get; set; }
        public int id_producto { get; set; }
        public int cantidad { get; set; }
        public DateTime fecha_movimiento { get; set; }
        public string tipo_movimiento { get; set; } = string.Empty; // "Entrada" o "Salida"
        public string? referencia { get; set; } = string.Empty;
    }
}
