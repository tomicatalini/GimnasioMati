
namespace DataLayer
{
    public class LineaMovimientoDTO
    {
        //Properties navigation
        public int Id { get; set; }
        public float PrecioUnitario { get; set; }
        public int Cantidad { get; set; }

        //Relationship navigation
        public virtual int MovimientoId { get; set; }
        public virtual MovimientoDTO Movimiento { get; set; }

        public virtual int CodProducto { get; set; }
        public virtual ProductoDTO Producto { get; set; }
    }
}
