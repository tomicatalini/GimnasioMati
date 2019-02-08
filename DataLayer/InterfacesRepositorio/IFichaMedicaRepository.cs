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
    /// Repositorio generico para el acceso a los Historiales Medicos
    /// </summary>
    public interface IFichaMedicaRepository : IRepository<FichaMedica>
    {
        //agregar metodos de historial medico.
    }
}
