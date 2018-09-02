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
        /// <summary>
        /// Devuelve el socio cuyo dni coincida con el dado
        /// </summary>
        /// <param name="pDNI">Parámetro de búsqueda</param>
        /// <returns></returns>
        IEnumerable<Socio> GetSocioActive(long pDNI);

        
        //Agregar métodos del socio. Ejemplo getSocio(long pDNI)
    }
}
