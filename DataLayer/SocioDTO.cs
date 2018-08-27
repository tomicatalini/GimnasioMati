using System;
using System.Collections.Generic;

namespace DataLayer
{
    public class SocioDTO
    {

        //Properties navigation
        public int dni { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fechaNac { get; set; }
        public string domicilio { get; set; }
        public int telefono { get; set; }
        public string mail { get; set; }

        //Relationship navigation
        public virtual IList<CuotaDTO> Cuotas { get; set; }
        public virtual IList<RutinaDTO> Rutinas { get; set; }
        public virtual IList<FichaMedicaDTO> HistorialMedico { get; set; }
    }
}
