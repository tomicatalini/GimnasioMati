using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class Cuota
    {
        public long nroCuta { get; set; }
        public DateTime fecEmision { get; set; }
        public string descripcion { get; set; }
        public float monto { get; set; }
        public bool pagada { get; set; }
        Mes mes { get; set; }
        public int año { get; set; }

        public Socio unSocio { get; set; }
        public IList<Pago> Pagos { get; set; }
    }
}
