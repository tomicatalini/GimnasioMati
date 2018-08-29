using System;
using System.Collections.Generic;

namespace DataLayer
{
    public class MovimientoDTO
    {
        //Properties navigation
        public int Id { get; set; }
        public TipoMovimientoDTO TipoMovimiento { get; set; }
        public DateTime Fecha { get; set; }


        //Relationship navigations
        public virtual IList<LineaMovimientoDTO> LineaMovimientos { get; set; }
    }
}
