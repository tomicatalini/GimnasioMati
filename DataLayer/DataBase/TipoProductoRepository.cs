using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer;
using DataLayer.InterfacesRepositorio;

namespace DataLayer.DataBase
{
    public class TipoProductoRepository : Repository<TipoProducto, GymMatiContext>, ITipoProductoRepository
    {
        public TipoProductoRepository(GymMatiContext pContext) : base(pContext) { }        
    }
}
