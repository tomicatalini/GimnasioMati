
namespace DataLayer
{
    public class ActividadFisicaDTO
    {
        //Properties navigation
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CantHoraSem { get; set; }

        //Relationship navigation
        public virtual int FichaId { get; set; }
        public virtual FichaMedicaDTO FichaMedica { get; set; }
    }
}
