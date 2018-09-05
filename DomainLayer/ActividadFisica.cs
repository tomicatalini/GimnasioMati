namespace DomainLayer
{
    public class ActividadFisica
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public int CantHoraSem { get; set; }

        public virtual int FichaId { get; set; }
        public virtual FichaMedica FichaMedica { get; set; }

    }
}