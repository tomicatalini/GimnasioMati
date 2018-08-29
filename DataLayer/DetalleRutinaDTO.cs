
namespace DataLayer
{
    public class DetalleRutinaDTO
    {
        //Properties navigation
        public int Id { get; set; }
        public int Dia { get; set; }
        public string Descanso { get; set; }
        public int SeriesxRepeticion { get; set; }

        //Relationship navigation
        public virtual int RutinaId { get; set; }
        public virtual RutinaDTO Rutina { get; set; }

        public virtual int MusculoId { get; set; }
        public virtual MusculoDTO Musculo { get; set; }

    }
}
