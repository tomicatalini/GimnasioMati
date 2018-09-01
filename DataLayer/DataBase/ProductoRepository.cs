using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer;

namespace DataLayer.DataBase
{
    /// <summary>
    /// Repositorio de entidad Producto
    /// </summary>
    public class ProductoRepository: Repository<Producto, GymMatiContext>, IProductoRepository
    {
        public ProductoRepository(GymMatiContext pContext) : base (pContext)
        {

        }
    }
}
