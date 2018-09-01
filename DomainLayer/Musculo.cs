using System;
using System.Collections.Generic;

namespace DomainLayer
{
    public class Musculo
    {
        public string nombre { get; set; }

        public IList<Ejercicio> Ejercicios { get; set; }
    }
}