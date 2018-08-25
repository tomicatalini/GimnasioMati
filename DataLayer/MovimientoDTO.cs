using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class MovimientoDTO
    {
        [Key]
        public int id { get; set; }
        public TipoMovimientoDTO tipoMovimiento { get; set; }
        public DateTime fecha { get; set; }
        public List<LineaMovimientoDTO> LineaMovimientos { get; set; }
    }
}
