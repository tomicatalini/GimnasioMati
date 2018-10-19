using System;

namespace DomainLayer
{
    public class Pago
    {
        public int NroPago { get; set; }
        public DateTime FecPago { get; set; }
        public float Importe { get; set; }

        public virtual int NroCuota { get; set; }
        public virtual Cuota Cuota { get; set; }

        public Pago(Cuota unaCuota ,DateTime fechaPago, float importe)
        {
            this.NroPago = 1;
            this.FecPago = fechaPago;
            this.Importe = importe;

            this.NroCuota = unaCuota.NroCuota;
            this.Cuota = unaCuota;
        }
    }
}