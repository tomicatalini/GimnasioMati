
namespace DataLayer
{
    public class MedicacionDTO
    {
        //Properties navigation
        public int Id { get; set; }
        public string Nombre { get; set; }

        //Relationship navigation
        public FichaMedicaDTO FichaMedica { get; set; }
    }
}
