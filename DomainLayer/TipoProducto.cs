using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class TipoProducto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual IList<Producto> Productos { get; set; }

        public TipoProducto() {}

        public TipoProducto(int id, string nombre)
        {

            this.Id = id;
            this.Nombre = nombre;

            this.Productos = new List<Producto>();
        }
    }
}
