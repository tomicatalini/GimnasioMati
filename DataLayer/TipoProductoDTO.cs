using System.Collections.Generic;

namespace DataLayer
{
    public class TipoProductoDTO
    {
        //Properties navigation
        public int Id { get; set; }
        public string Nombre { get; set; }

        //Relationship navigation
        public IList<ProductoDTO> Productos { get; set; }
    }
}
