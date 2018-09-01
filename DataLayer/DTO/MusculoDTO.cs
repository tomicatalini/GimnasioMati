using System.Collections.Generic;

namespace DataLayer
{
    public class MusculoDTO
    {
        //Properties navigation
        public int Id { get; set; }
        public string Nombre { get; set; }

        //Relationship navigation
        public virtual IList<DetalleRutinaDTO> DetallesDeRutina { get; set; }
        public virtual IList<EjercicioDTO> Ejercicios { get; set; }
    }
}
