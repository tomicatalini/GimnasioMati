using System;
using System.Collections.Generic;

namespace DataLayer
{
    public class RutinaDTO
    {
        //Properties Navigation
        public int id { get; set; }
        public string nombre { get; set; }
        public int cantDias { get; set; }
        public DateTime fechaInicio { get; set; }

        //Relationship Navigation
        public virtual IList<SocioDTO> Socios { get; set; }
        public virtual IList<DetalleRutinaDTO> DetalleRutinas { get; set; }

    }
}
