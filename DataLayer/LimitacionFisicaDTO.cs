using System;

namespace DataLayer
{
    public class LimitacionFisicaDTO
    {
        //Properties navigation
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaOcurrencia { get; set; }
        public DateTime FechaRecuperacion { get; set; }

        //Relationship navigation
        public virtual int FichaId { get; set; }
        public virtual FichaMedicaDTO FichaMedica { get; set; }

    }
}
