using System;
using System.Collections.Generic;


namespace DataLayer
{
    public class CuotaDTO
    {
        //Properties navigation
        public int nroCuota { get; set; }
        public DateTime fechaEmision { get; set; }
        public string descripcion { get; set; }
        public float monto { get; set; }
        public bool pagada { get; set; }
        public MesDTO mes { get; set; }
        public int año { get; set; }

        //Relationship navigation
        public virtual SocioDTO socio { get; set; }
        public virtual List<PagoDTO> Pagos { get; set; }
    
    }
}
