using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLayer.InterfacesRepositorio
{

    public interface IRepository<TEntity> 
        where TEntity: class
    {
        /// <summary>
        /// Añade una entidad al repositorio
        /// </summary>
        /// <param name="pEntity">Entidad a agregar</param>
        void add(TEntity pEntity);

        /// <summary>
        /// Elimina una entidad del repositorio
        /// </summary>
        /// <param name="pEntity">entidad a eliminar</param>
        void remove(TEntity pEntity);

        /// <summary>
        /// Obtiene una entidad por su ID
        /// </summary>
        /// <param name="pId">id de la entidad que se quiere obtener</param>
        /// <returns>la entidad con el id especificado</returns>
        TEntity Get(int pId);

        /// <summary>
        /// obtiene todas las entidades almacenadas en el repositorio
        /// </summary>
        /// <returns>una coleccion de entidades</returns>
        IEnumerable<TEntity> GetAll();

    }
}
