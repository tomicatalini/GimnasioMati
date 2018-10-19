using System.Collections.Generic;
using System.Linq;
using DomainLayer;
using AutoMapper;

namespace DataLayer.DataBase
{
    /// <summary>
    /// Repositorio de entidad socio
    /// </summary>
    public class SocioRepository : Repository<Socio, GymMatiContext>, ISocioRepository
    {
        public SocioRepository(GymMatiContext pContext) : base (pContext) { }             

        public IList<Socio> GetSociosByString(string pCadena)
        {
            return this.iDbContext.Socios.Where(unSocio => unSocio.Apellido.StartsWith(pCadena)).ToList();
        }

        public IList<Socio> GetSociosActivos()
        {
            return this.iDbContext.Socios.Where(unSocio => unSocio.Activo).ToList();
        }
    }
    
}
