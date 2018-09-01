using System.Collections.Generic;

namespace DomainLayer
{
    public class Producto
    {
        public long codProducto { get; set; }
        public string nombre { get; set; }
        public float precio { get; set; }
        public int stock { get; set; }
        public string descripcion { get; set; }
        public bool activo { get; set; }

        public TipoProducto tipoProducto { get; set; }
        public IList<LineaMovimiento> lineaMovimiento { get; set; }


    }
}