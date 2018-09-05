//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer;
using AutoMapper;

namespace DataLayer.DataBase
{
    /// <summary>
    /// Repositorio de entidad socio
    /// </summary>
    public class SocioRepository : Repository<SocioDTO, GymMatiContext>, ISocioRepository
    {
        public SocioRepository(GymMatiContext pContext) : base (pContext) { }

        //SE SACO EL METODO GETSOCIOACTIVE

        /// <summary>
        /// Determina la existencia de un socio
        /// </summary>
        /// <param name="pDni"></param>
        /// <returns></returns>
        public bool Exist(long pDni)
        {
            return this.iDbContext.Socios.Contains(pDni);
        }


        //public IList<SocioDTO> GetByName(string pPacialName)
        //{
        //    this.iDbContext.Socios.SqlQuery("SELECT * FROM dbo.Socio Where DNI like" + pPacialName + "%");
        //}
        
    }
    
}
