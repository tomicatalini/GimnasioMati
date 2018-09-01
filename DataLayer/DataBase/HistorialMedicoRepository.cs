using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer;

namespace DataLayer.DataBase
{   
    /// <summary>
    /// Repositorio de entidad HistorialMedico
    /// </summary>
    public class HistorialMedicoRepository : Repository<HistorialMedico, GymMatiContext>, IHistorialMedicoRepository
    {
        public HistorialMedicoRepository(GymMatiContext pContext) : base (pContext)
        {

        }
    }
}
