namespace DomainLayer
{
    public class Ejercicio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual int MusculoId { get; set; }
        public virtual Musculo Musculo { get; set; }

        public Ejercicio(string nombre)
        {
            this.Nombre = nombre;
        }

        public void AsociarMusculo(Musculo musculo)
        {
            this.MusculoId = musculo.Id;
            this.Musculo = musculo;
        }
    }
}