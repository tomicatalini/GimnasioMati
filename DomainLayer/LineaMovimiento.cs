using System;
using System.Collections.Generic;

namespace DomainLayer
{
    public class LineaMovimiento
    {
        public int cantidad { get; set; }
        public float precioUnitario { get; set; }
        
        public Movimiento unMovimiento { get; set; }
        public Producto unProducto { get; set; }
    }
}