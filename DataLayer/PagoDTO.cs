using System;

namespace DataLayer
{
    public class PagoDTO
    {
        //Properties navigation   
        public int NroPago { get; set; }
        public DateTime FechaPago { get; set; }
        public float Importe { get; set; }

        //Relationship navigation
        public virtual int NroCuota { get; set; }
        public virtual CuotaDTO Cuota { get; set; }
    }
}
