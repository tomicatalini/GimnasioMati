using System.Collections.Generic;

namespace DataLayer
{
    public class ProductoDTO
    {
        //Properties navigation
        public int CodProducto { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Contenido { get; set; }
        public float Precio { get; set; }        
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public string TipoProducto { get; set; }
    }
}
