using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer;
using DataLayer.InterfacesRepositorio;

namespace DataLayer.DataBase
{
    class DetalleRutinaRepository : Repository<DetalleRutina, GymMatiContext>, IDetalleRutinaRepository
    {
        public DetalleRutinaRepository(GymMatiContext pContext) : base(pContext) { }
    }
}
