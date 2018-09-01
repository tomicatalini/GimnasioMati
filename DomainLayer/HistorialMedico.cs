using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class HistorialMedico
    { 
        public DateTime fecEntrega { get; set; }
        public long telContEmer { get; set; }
        public string nomContEmer { get; set; }
        public int peso { get; set; }
        public int altura { get; set; }
        public string grupSanguineo { get; set; }
        public bool hiperArterial { get; set; }
        public bool diabetes { get; set; }
        public bool afecCardioVascular { get; set; }
        public bool afecCardioRespiratoria { get; set; }
        public bool fuma { get; set; }
        public bool alcohol { get; set; }

        public Socio unSocio { get; set; }
        public IList<LimitacionFisica> limitacionesFisicas { get; set; }
        public IList<Operacion> Operaciones { get; set; }
        public IList<ActividadFisica> actividadesFisicas { get; set; }
        public IList<Enfermedad> Enfermedades { get; set; }
        public IList<Medicacion> Medicaciones { get; set; }
    }
}
