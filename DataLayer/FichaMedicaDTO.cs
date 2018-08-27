using System.Collections.Generic;


namespace DataLayer
{
    public class FichaMedicaDTO
    {
        //Properties navigation
        public int id { get; set; }
        public int peso { get; set; }
        public int altura { get; set; }
        public string grupoSanguineo { get; set; }
        public bool hiperArterial { get; set; }
        public bool diabetes { get; set; }
        public bool afecCardVascular { get; set; }
        public bool afecResp { get; set; }
        public bool fuma { get; set; }
        public bool alcohol { get; set; }

        //Relationship Navigation
        public virtual SocioDTO socio { get; set; }

        public virtual IList<ContactoEmergenciaDTO> ContactoEmergencia { get; set; }
        public virtual IList<MedicacionDTO> Medicaciones { get; set; }
        public virtual IList<EnfermedadDTO> Enfermedades { get; set; }
        public virtual IList<ActividadFisicaDTO> ActividadesFisicas { get; set; }
        public virtual IList<OperacionDTO> Operaciones { get; set; }
        public virtual IList<LimitacionFisicaDTO> LimitacionesFisicas { get; set; }
    }
}
