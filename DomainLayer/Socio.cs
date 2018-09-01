using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class Socio
    {
        public long ID { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fecNacimiento { get; set; }
        public long telefono { get; set; }
        public string mail { get; set; }

        public IList<Rutina> Rutinas { get; set; }
        public IList<Cuota> Cuotas { get; set; }
        public IList<HistorialMedico> historialMedico { get; set; }


    }
}
