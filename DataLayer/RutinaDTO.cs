using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class RutinaDTO
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }
        public int cantDias { get; set; }
        public DateTime fechaInicio { get; set; }
        public List<SocioDTO> Socios { get; set; }
        public List<DetalleRutinaDTO> DetalleRutinas { get; set; }

    }
}
