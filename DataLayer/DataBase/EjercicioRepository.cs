using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer;
using DataLayer.InterfacesRepositorio;

namespace DataLayer.DataBase
{
    class EjercicioRepository: Repository<Ejercicio, GymMatiContext>, IEjercicioRepository
    {
        public EjercicioRepository(GymMatiContext pContext) : base(pContext) { }
}
}
