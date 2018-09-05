using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class LineaEjercicio
    {
        public virtual int MusculoId { get; set; }
        public virtual Musculo Musculo { get; set; }

        public virtual int EjercicioId { get; set; }
        public virtual Ejercicio Ejercicio { get; set; }

        public string SerieRepeticion { get; set; }
        public int Descanso { get; set; }
        //public string Observacion; //Para detallar pesos, o alguna especificacion.

        public LineaEjercicio(Musculo musculo, Ejercicio ejercicio, string serieRepeticion, int descanso)
        {
            this.EjercicioId = ejercicio.Id;
            this.Ejercicio = ejercicio;

            this.MusculoId = musculo.Id;
            this.Musculo = musculo;

            this.SerieRepeticion = serieRepeticion;
            this.Descanso = descanso;
        }
    }
}
