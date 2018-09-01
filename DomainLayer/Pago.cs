using System;

namespace DomainLayer
{
    public class Pago
    {
        public long nroPago { get; set; }
        public DateTime fecPago { get; set; }
        public float importe { get; set; }

        public Cuota unaCuota { get; set; }
    }
}