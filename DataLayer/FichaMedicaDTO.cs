using System.Collections.Generic;
using System;


namespace DataLayer
{
    public class FichaMedicaDTO
    {
        //Properties navigation
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
        public virtual SocioDTO Socio { get; set; }

        public virtual IList<ContactoEmergenciaDTO> ContactoEmergencia { get; set; }
        public virtual IList<MedicacionDTO> Medicaciones { get; set; }
        public virtual IList<EnfermedadDTO> Enfermedades { get; set; }
        public virtual IList<ActividadFisicaDTO> ActividadesFisicas { get; set; }
        public virtual IList<OperacionDTO> Operaciones { get; set; }
        public virtual IList<LimitacionFisicaDTO> LimitacionesFisicas { get; set; }
    }
}
