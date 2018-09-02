using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    /// <summary>
    /// Interfaz para el servicio de socios
    /// </summary>
    public interface ISocioService : IObservable<string>
    {
        /// <summary>
        /// Crea un socio
        /// </summary>
        /// <param name="pSocioDTO">Socio que se requiere crear</param>
        void Create(SocioDTO pSocioDTO);

        /// <summary>
        /// Elimina un Socio
        /// </summary>
        /// <param name="pSocioDTO">Socio que se requiere eliminar</param>
        void Remove(SocioDTO pSocioDTO);

        /// <summary>
        /// Actualiza un socio
        /// </summary>
        /// <param name="pSocioDTO">Socio que se requiere actualizar</param>
        void Update(SocioDTO pSocioDTO);

        /// <summary>
        /// Obtiene un Socio por su DNI
        /// </summary>
        /// <param name="pDNI">DNI del socio que se quiere obtener</param>
        /// <returns></returns>
        SocioDTO Get(int pDNI);

        /// <summary>
        /// Obtiene todos los socios
        /// </summary>
        /// <returns></returns>
        IEnumerable<SocioDTO> GetAll();
    }
}
