using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class CuotaDTO
    {
        [Key]
        public int nroCuota { get; set; }
        public System.DateTime fechaEmision { get; set; }
        public string descripcion { get; set; }
        public float monto { get; set; }
        public bool pagada { get; set; }
        public MesDTO mes { get; set; }
        public int año { get; set; }
        public List<PagoDTO> Pagos { get; set; }
    }
}
