using System.Collections.Generic;

namespace DomainLayer
{
    public class DetalleRutina
    {
        public int Id { get; set; }
        public int Dia { get; set; }
        public string SeriesxRepeticiones { get; set; }
        public int Descanso { get; set; }

        public virtual int RutinaId { get; set; }
        public virtual Rutina Rutina { get; set; }

        public virtual int MusculoId { get; set; }
        public virtual Musculo Musculo { get; set; }

        //public virtual IList<LineaEjercicio> LineasEjercicio { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dia"></param>
        /// <param name="serieRepeticiones"></param>
        /// <param name="descanso"></param>
        /// <param name="rutina"></param>
        /// <param name="musculo"></param>
        public DetalleRutina(int dia,string serieRepeticiones, int descanso, Rutina rutina)
        {

            this.Dia = dia;
            this.SeriesxRepeticiones = serieRepeticiones;
            this.Descanso = descanso;

            this.RutinaId = rutina.Id;
            this.Rutina = rutina;

            //this.LineasEjercicio = new List<LineaEjercicio>();
        }

    }
}