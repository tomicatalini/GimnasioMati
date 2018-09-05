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
    /// Repositorio generico para el acceso a las cuotas
    /// </summary>
    public interface ICuotaRepository : IRepository<Cuota>
    {
        
    }
}
