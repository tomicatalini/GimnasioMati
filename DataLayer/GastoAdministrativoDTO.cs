using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class GastoAdministrativoDTO
    {
        [Key]
        public int id { get; set; }
        public int cantidad { get; set; }
        public string descripcion { get; set; }
        public float precioUnitario { get; set; }
        public DateTime fecha { get; set; }
    }
}
