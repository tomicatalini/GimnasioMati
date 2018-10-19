using DataLayer.InterfacesRepositorio;
using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataBase
{

    /// <summary>
    /// Repositorio generico para el acceso a los Socios.
    /// </summary>
    public interface ISocioRepository: IRepository<Socio>
    {
        IList<Socio> GetSociosByString(string pCadena);
        IList<Socio> GetSociosActivos();
    }
}
