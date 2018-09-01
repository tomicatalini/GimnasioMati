using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer;

namespace DataLayer.DataBase
{
    /// <summary>
    /// Repositorio de entidad Rutina
    /// </summary>
    public class RutinaRepository: Repository<Rutina, GymMatiContext>, IRutinaRepository
    {
        public RutinaRepository(GymMatiContext pContext) : base (pContext)
        {

        }
    }
}
