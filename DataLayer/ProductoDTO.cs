using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class ProductoDTO
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }
        public float precio { get; set; }
        public int stock { get; set; }
        public string descripcion { get; set; }
        public bool activo { get; set; }
        public int codProducto { get; set; }
        public TipoProductoDTO TipoProducto { get; set; }
        public List<LineaMovimientoDTO> LineaMovimientos { get; set; }
    }
}
