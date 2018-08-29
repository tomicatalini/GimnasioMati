
namespace DataLayer
{
    public class MedicacionDTO
    {
        //Properties navigation
        public int Id { get; set; }
        public string Nombre { get; set; }

        //Relationship navigation
        public virtual int FichaId { get; set; }
        public virtual FichaMedicaDTO FichaMedica { get; set; }
    }
}
