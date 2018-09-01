using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class GastoAdministrativo
    {
        public int cantidad { get; set; }
        public string descripcion { get; set; }
        public float precioUnitario { get; set; }
        public DateTime fecha { get; set; }
    }
}
