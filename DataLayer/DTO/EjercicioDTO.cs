
namespace DataLayer
{
    public class EjercicioDTO
    {
        //Properties navigation
        public int Id { get; set; }
        public string Nombre { get; set; }

        //Relationship navigation
        public virtual int MusculoId { get; set; }
        public virtual MusculoDTO Musculo { get; set; }

    }
}
