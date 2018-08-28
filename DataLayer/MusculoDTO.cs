using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class MusculoDTO
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }

        public virtual IList<DetalleRutinaDTO> DetallesDeRutina { get; set; }
        public List<EjercicioDTO> Ejercicios { get; set; }
    }
}
