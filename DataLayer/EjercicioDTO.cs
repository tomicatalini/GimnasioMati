using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace DataLayer
{
    public class EjercicioDTO
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }
        public MusculoDTO musculo { get; set; }

    }
}
