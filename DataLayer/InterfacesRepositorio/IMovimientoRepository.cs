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
    /// Repositorio generico para el acceso a los Movimientos
    /// </summary>
    public interface IMovimientoRepository: IRepository<Movimiento>
    {
        //Agregar metodos de movimientos.
    }
}
