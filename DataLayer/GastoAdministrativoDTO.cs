using System;

namespace DataLayer
{
    public class GastoAdministrativoDTO
    {
        //Properties navigation
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public float PrecioUnitario { get; set; }
        public DateTime Fecha { get; set; }
    }
}
