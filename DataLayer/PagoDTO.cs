using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class PagoDTO
    {
        [Key]
        public int nroPago { get; set; }
        public DateTime fechaPago { get; set; }
        public float importe { get; set; }
        public CuotaDTO Cuota { get; set; }

    }
}
