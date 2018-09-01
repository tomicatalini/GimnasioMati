using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using DataLayer.InterfacesRepositorio;

namespace DataLayer.DataBase
{
    public abstract class Repository<TEntity, TDbContext> : IRepository<TEntity> 
        where TEntity : class
        where TDbContext : DbContext
    {
        
        protected readonly TDbContext iDbContext;

        public Repository(TDbContext pContext)
        {
            if (pContext == null)
            {
                throw new ArgumentNullException(nameof(pContext));
            }

            this.iDbContext = pContext;
        }

        /// <summary>
        /// Agrega la entidad
        /// </summary>
        /// <param name="entity"></param>
        public void Create(TEntity pEntity)
        {
            if (pEntity == null)
            {
                throw new ArgumentNullException(nameof(pEntity));
            }

            this.iDbContext.Set<TEntity>().Add(pEntity);
        }

        /// <summary>
        /// Elimina la entidad
        /// </summary>
        /// <param name="entity"></param>
        public void Remove(TEntity pEntity)
        {
            if (pEntity == null)
            {
                throw new ArgumentNullException(nameof(pEntity));
            }

            this.iDbContext.Set<TEntity>().Remove(pEntity);
        }

        /// <summary>
        /// Persiste los cambios en la BD
        /// </summary>
        /// <param name="entity"></param>
        public void SaveChanges(TEntity entity)
        {
            iDbContext.SaveChanges();
        }

        /// <summary>
        /// Obtiene la identidad por ID
        /// </summary>
        /// <param name="pId">Identificador de la entidad</param>
        /// <returns>Entidad</returns>
        public virtual TEntity Get(int pId)
        {
            return this.iDbContext.Set<TEntity>().Find(pId);
        }

        /// <summary>
        /// Obtiene todas las entidades
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<TEntity> GetAll()
        {
            return this.iDbContext.Set<TEntity>().ToList();
        }

        public void add(TEntity pEntity)
        {
            throw new NotImplementedException();
        }

        public void remove(TEntity pEntity)
        {
            throw new NotImplementedException();
        }
    }
}
