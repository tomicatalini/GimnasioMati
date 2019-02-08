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
    /// Repositorio de entidad HistorialMedico
    /// </summary>
    public class FichaMedicaRepository : Repository<FichaMedica, GymMatiContext>, IFichaMedicaRepository
    {
        public FichaMedicaRepository(GymMatiContext pContext) : base (pContext)
        {

        }
    }
}
