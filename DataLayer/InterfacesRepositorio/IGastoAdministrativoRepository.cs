using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer;
using DataLayer.InterfacesRepositorio;

namespace DataLayer.DataBase
{
    /// <summary>
    /// Repositorio generico para acceder a los GastosAdministrativos
    /// </summary>
    public interface IGastoAdministrativoRepository: IRepository<GastoAdministrativo>
    {
        //Agregar metodos de gastosAdministrativos.
    }
}
