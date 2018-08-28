using System;
using System.Collections.Generic;

namespace DataLayer
{
    public class RutinaDTO
    {
        //Properties Navigation
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CantDias { get; set; }
        public DateTime FechaInicio { get; set; }

        //Relationship Navigation
        public virtual IList<SocioDTO> Socios { get; set; }
        public virtual IList<DetalleRutinaDTO> DetalleRutinas { get; set; }

    }
}
