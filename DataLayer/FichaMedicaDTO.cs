using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace DataLayer
{
    public class FichaMedicaDTO
    {
        [Key]
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
        public List<ContactoEmergenciaDTO> ContactoEmergencia { get; set; }
        public List<MedicacionDTO> Medicaciones { get; set; }
        public List<EnfermedadDTO> Enfermedades { get; set; }
        public List<ActividadFisicaDTO> ActividadesFisicas { get; set; }
        public List<OperacionDTO> Operaciones { get; set; }
        public List<LimitacionFisicaDTO> LimitacionesFisicas { get; set; }
    }
}
