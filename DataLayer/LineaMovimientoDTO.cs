using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class LineaMovimientoDTO
    {
        [Key]
        public int id { get; set; }
        public float precioUnitario { get; set; }
        public int cantidad { get; set; }
        public MovimientoDTO Movimiento { get; set; }
        public ProductoDTO Producto { get; set; }
    }
}
