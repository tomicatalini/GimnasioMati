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
    /// Repositorio generico para el acceso a las Rutinas
    /// </summary>
    public interface IRutinaRepository: IRepository<Rutina>
    {
        //agregar metodos de rutina.
    }
}
