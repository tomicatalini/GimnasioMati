using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer;

namespace DataLayer.DataBase
{
    /// <summary>
    /// Repositorio de entidad Cuota
    /// </summary>
    public class CuotaRepository : Repository<Cuota, GymMatiContext>, ICuotaRepository 
    {
        public CuotaRepository(GymMatiContext pContext) : base (pContext)
        {

        }
    }
}
