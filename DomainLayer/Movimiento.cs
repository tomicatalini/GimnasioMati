using System;
using System.Collections.Generic;


namespace DomainLayer
{
    public class Movimiento
    {
        public DateTime fecha { get; set; }
        TipoMovimiento tipoMovimiento { get; set; }

        public IList<LineaMovimiento> lineaMovimientos { get; set; }
    }
}