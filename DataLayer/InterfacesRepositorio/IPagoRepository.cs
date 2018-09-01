using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.InterfacesRepositorio;
using DomainLayer;

namespace DataLayer.DataBase
{
    /// <summary>
    /// Repositorio generico para acceder a los Pagos
    /// </summary>
    public interface IPagoRepository : IRepository<Pago>
    {
        //Agregar metodos de pago.
    }
}
