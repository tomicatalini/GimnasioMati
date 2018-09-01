using System;
using System.Collections.Generic;


namespace DataLayer
{
    public class CuotaDTO
    {
        //Properties navigation
        public int NroCuota { get; set; }
        public DateTime FechaEmision { get; set; }
        public string Descripcion { get; set; }
        public float Monto { get; set; }
        public bool Pagada { get; set; }
        public MesDTO Mes { get; set; }
        public int Año { get; set; }

        //Relationship navigation
        public virtual long socioDNI { get; set; }
        public virtual SocioDTO Socio { get; set; }

        public virtual IList<PagoDTO> Pagos { get; set; }
    
    }
}
