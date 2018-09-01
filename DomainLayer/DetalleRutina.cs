namespace DomainLayer
{
    public class DetalleRutina
    {
        public int dia { get; set; }
        public int seriesxRepeticiones { get; set; }
        public string descanso { get; set; }

        public Rutina unaRutina { get; set; }
        public Musculo musculo { get; set; }

    }
}