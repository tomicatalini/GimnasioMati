using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.InterfacesRepositorio
{
    /// <summary>
    /// Representa una transaccion con la BD
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Persiste los cambios
        /// </summary>
        void Complete();
    }
}
