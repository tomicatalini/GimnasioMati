using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class Cuota
    {
        public int NroCuota { get; set; }
        public DateTime FecEmision { get; set; }
        public string Descripcion { get; set; }
        public float Monto { get; set; }
        public bool Pagada { get; set; }
        //public Mes Mes { get; set; }
        public string Mes { get; set; }
        public int Año { get; set; }

        public virtual int SocioDNI { get; set; }
        public virtual Socio Socio { get; set; }
        public virtual IList<Pago> Pagos { get; set; }

        public Cuota(DateTime pFecEmision, string pDescripcion, float pMonto, string pMes, int pAño, Socio unSocio)
        {
                      
            NroCuota = 1;
            FecEmision = pFecEmision;
            Descripcion = pDescripcion;
            Monto = pMonto;
            Mes = pMes;
            Año = pAño;

            SocioDNI = unSocio.DNI;
            Socio = unSocio;

            Pagos = new List<Pago>();
        }

        public void Cancelada()
        {
            float montoPagos = 0;

            foreach (var unPago in this.Pagos)
            {
                montoPagos += unPago.Importe; 
            }

            if (montoPagos == this.Monto)
            {
                this.Pagada = true;
            }
            else
            {
                this.Pagada = false;
            }
            
        }
    }
}
