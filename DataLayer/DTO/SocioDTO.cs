using System;
using System.Collections.Generic;

namespace DataLayer
{
    public class SocioDTO
    {

        //Properties navigation
        public long DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        public string Domicilio { get; set; }
        public int Telefono { get; set; }
        public string Mail { get; set; }
        public bool Activo { get; set; }

        //Relationship navigation
        public virtual IList<CuotaDTO> Cuotas { get; set; }
        public virtual IList<RutinaDTO> Rutinas { get; set; }
        public virtual IList<FichaMedicaDTO> HistorialMedico { get; set; }
    }
}
