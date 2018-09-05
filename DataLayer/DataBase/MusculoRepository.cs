using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.InterfacesRepositorio;
using DomainLayer;

namespace DataLayer.DataBase
{
    public class MusculoRepository: Repository<Musculo, GymMatiContext>, IMusculoRepository
    {
        public MusculoRepository(GymMatiContext pContext) : base(pContext) { }
    }
}
