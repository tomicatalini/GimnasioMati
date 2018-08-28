
namespace DataLayer
{
    public class LineaMovimientoDTO
    {
        //Properties navigation
        public int Id { get; set; }
        public float PrecioUnitario { get; set; }
        public int Cantidad { get; set; }

        //Relationship navigation
        public MovimientoDTO Movimiento { get; set; }
        public ProductoDTO Producto { get; set; }
    }
}
