using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class LimitacionFisicaDTO
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }
        public DateTime fechaOcurrencia { get; set; }
        public DateTime fechaRecuperacion { get; set; }
        public FichaMedicaDTO fichaMedica { get; set; }

    }
}
