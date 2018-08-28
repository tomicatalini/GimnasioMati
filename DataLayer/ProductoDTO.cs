using System.Collections.Generic;

namespace DataLayer
{
    public class ProductoDTO
    {
        //Properties navigation
        public int CodProducto { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }        
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public bool Activo { get; set; }

        //Relationship navigation
        public TipoProductoDTO TipoProducto { get; set; }
        public IList<LineaMovimientoDTO> LineaMovimientos { get; set; }
    }
}
