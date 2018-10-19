using System;
using System.Collections.Generic;

namespace DomainLayer
{
    public class LineaMovimiento
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public float PrecioUnitario { get; set; }
        
        public virtual int MovimientoId { get; set; }
        public virtual Movimiento Movimiento { get; set; }

        public virtual int CodProducto { get; set; }
        public virtual Producto Producto { get; set; }
    }
}