using System;

namespace DataLayer
{
    public class PagoDTO
    {
        //Properties navigation   
        public int nroPago { get; set; }
        public DateTime fechaPago { get; set; }
        public float importe { get; set; }

        //Relationship navigation
        public virtual CuotaDTO Cuota { get; set; }
    }
}
