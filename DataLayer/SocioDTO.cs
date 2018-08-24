using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema; en caso de que quiera autoincremetar algn valor
//[DatabaseGenerated(DatabaseGeneratedOption.Identity)]

namespace DataLayer
{
    public class SocioDTO
    {
        
        [Key]        
        public int dni { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fechaNac { get; set; }
        public string domicilio { get; set; }
        public int telefono { get; set; }
        public string mail { get; set; }

       // public bool 
    }
}
