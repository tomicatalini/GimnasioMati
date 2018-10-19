using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class FichaMedica
    {
        //Properties navigation
        public int FichaId { get; set; }
        public DateTime FechaEntrega { get; set; }
        public int Peso { get; set; }
        public int Altura { get; set; }
        public string GrupoSanguineo { get; set; }
        public bool HiperArterial { get; set; }
        public bool Diabetes { get; set; }
        public bool AfecCardVascular { get; set; }
        public bool AfecResp { get; set; }
        public bool Fuma { get; set; }
        public bool Alcohol { get; set; }

        //Relationship Navigation
        public virtual int SocioDNI { get; set; }
        public virtual Socio Socio { get; set; }

        public virtual IList<ContactoEmergencia> ContactoEmergencia { get; set; }
        public virtual IList<Medicacion> Medicaciones { get; set; }
        public virtual IList<Enfermedad> Enfermedades { get; set; }
        public virtual IList<ActividadFisica> ActividadesFisicas { get; set; }
        public virtual IList<Operacion> Operaciones { get; set; }
        public virtual IList<LimitacionFisica> LimitacionesFisicas { get; set; }
    }
}
