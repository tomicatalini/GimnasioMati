
namespace DataLayer
{
    public class ContactoEmergenciaDTO
    {
        //Properties navigation
        public int Id { get; set; }
        public string Nombre { get; set; }
        public long Telefono { get; set; }

        //Relationship navigation
        public FichaMedicaDTO FichaMedica { get; set; }
    }
}
