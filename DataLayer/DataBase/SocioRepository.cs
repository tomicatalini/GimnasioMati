using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer;

namespace DataLayer.DataBase
{
    /// <summary>
    /// Repositorio de entidad socio
    /// </summary>
    public class SocioRepository : Repository<Socio, GymMatiContext>, ISocioRepository
    {
        public SocioRepository(GymMatiContext pContext) : base (pContext)
        {

        }
    }
    
}
