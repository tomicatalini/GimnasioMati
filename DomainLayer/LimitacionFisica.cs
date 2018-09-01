using System;

namespace DomainLayer
{
    public class LimitacionFisica
    {
        public string nombre { get; set; }
        public DateTime fecOcurrencia { get; set; }
        public DateTime fecRecuperacion { get; set; }
        public HistorialMedico historialMedico { get; set; }
    }
}