using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.InterfacesRepositorio;
using DataLayer.DataBase;

namespace DataLayer.DataBase
{
    /// <summary>
    /// Implementacion del patron Unit of Work
    /// </summary>
    public class UnitOfWork: IUnitOfWork
    {
        private readonly GymMatiContext iDbContext;

        public UnitOfWork(GymMatiContext pContext)
        {
            if (pContext == null)
            {
                throw new ArgumentNullException(nameof(pContext));
            }

            this.iDbContext = pContext;

            this.SocioRepository = new SocioRepository(this.iDbContext);
            this.CuotaRepository = new CuotaRepository(this.iDbContext);
            this.DetalleRutinaRepository = new DetalleRutinaRepository(this.iDbContext);
            this.EjercicioRepository = new EjercicioRepository(this.iDbContext);
            this.MusculoRepository = new MusculoRepository(this.iDbContext);
            //this.PagoRepository = new PagoRepository(this.iDbContext);
            this.RutinaRepository = new RutinaRepository(this.iDbContext);
            //this.MovimientoRepository = new MovimientoRepository(this.iDbContext);
            //this.GastoAdministrativoRepository = new GastoAdministrativoRepository(this.iDbContext);
            this.ProductoRepository = new ProductoRepository(this.iDbContext);
            this.FichaMedicaRepository = new FichaMedicaRepository(this.iDbContext);
            //this.MarcaRepository = new MarcaRepository(this.iDbContext);
            this.TipoProductoRepository = new TipoProductoRepository(this.iDbContext);
        }

        public ISocioRepository SocioRepository { get; private set; }

        public ICuotaRepository CuotaRepository { get; private set; }

        public IDetalleRutinaRepository DetalleRutinaRepository { get; private set; }
        public IEjercicioRepository EjercicioRepository { get; private set; }
        public IMusculoRepository MusculoRepository { get; private set; }
        //public IPagoRepository PagoRepository
        //{
        //    get; private set;
        //}

        public IRutinaRepository RutinaRepository{ get; private set; }

        //public IMovimientoRepository MovimientoRepository
        //{
        //    get; private set;
        //}

        //public IGastoAdministrativoRepository GastoAdministrativoRepository
        //{
        //    get; private set;
        //}

        public IProductoRepository ProductoRepository
        {
            get; private set;
        }

        //public IMarcaRepository MarcaRepository { get; private set; }
        public ITipoProductoRepository TipoProductoRepository { get; private set; }

        public IFichaMedicaRepository FichaMedicaRepository
        {
            get; private set;
        }

        public void Complete()
        {
            this.iDbContext.SaveChanges();
        }

        public void Dispose()
        {
            this.iDbContext.Dispose();
        }
    }
}
