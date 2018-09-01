using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class Rutina
    {
        public string nombre { get; set; }
        public int cantDias { get; set; }
        public DateTime fecInicio { get; set; }

        public IList<Socio> Socios { get; set; }
        public IList<DetalleRutina> detallesRutina { get; set; }
    }
}
