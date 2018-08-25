using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class DetalleRutinaDTO
    {
        [Key]

        public int id { get; set; }
        public int dia { get; set; }
        public string descanso { get; set; }
        public int seriesxRepeticion { get; set; }
        public MusculoDTO musculo { get; set; }

    }
}
