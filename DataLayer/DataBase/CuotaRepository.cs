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
    public class CuotaRepository : Repository<CuotaDTO, GymMatiContext>, ICuotaRepository 
    {
        public CuotaRepository(GymMatiContext pContext) : base (pContext) {}

        /// <summary>
        /// Buscar
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        //public IQueryable<CuotaDTO> SearchFor(this IQueryable<CuotaDTO> source, Expression<Func<TSource, bool>> predicate)
        //{
        //    return this.iDbContext.Cuotas.Where(predicate);
        //}

        public CuotaDTO UltimaCuotaSocio(long pDni)
        {
            //Obtiene las cuotas de un socio determinado
            List<CuotaDTO> cuotasSocio = this.iDbContext.Cuotas.Where(unCuota => unaCuota.socioDNI);

            //Ordena la lista de cuotas en forma ascendente
            cuotasSocio.OrderBy();

            //Devuelve la ultima cuota de la lista
            return cuotasSocio.Last();
        }
    }
}
