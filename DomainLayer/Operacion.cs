using System;

namespace DomainLayer
{
    public class Operacion
    {
        public string nombre { get; set; }
        public DateTime fecOperacion { get; set; }
        public DateTime fecAltaMedica { get; set; }
        public HistorialMedico historialMedico { get; set; }

    }
}