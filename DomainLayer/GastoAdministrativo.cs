using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class GastoAdministrativo
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public float PrecioUnitario { get; set; }
        public DateTime Fecha { get; set; }
    }
}
