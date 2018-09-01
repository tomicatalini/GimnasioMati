using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class TipoProducto
    {
        public string nombre { get; set; }
        public IList<Producto> Productos { get; set; }
    }
}
