using System;
using System.Collections.Generic;
using DataLayer;
using DataLayer.DataBase;
using DomainLayer;

namespace BusinessLayer.Controladores
{
    class ControladorCuota
    {
        /// <summary>
        /// Contexto de base de datos junto con el patron UnitOfWork
        /// </summary>
        private UnitOfWork iUnitOfWork;

        /// <summary>
        /// Constructor
        /// </summary>
        public ControladorCuota()
        {
            this.iUnitOfWork = new UnitOfWork(new GymMatiContext());
        }

        /// <summary>
        /// Alta de una nueva Cuota
        /// </summary>
        /// <param name="pFechaEmision"></param>
        /// <param name="pMes"></param>
        /// <param name="pAño"></param>
        /// <param name="pDescripcion"></param>
        /// <param name="pMonto"></param>
        public void AltaCuota(string pMes, int pAño, string pDescripcion, float pMonto, int dniSocio)
        {

            var unSocio = this.iUnitOfWork.SocioRepository.Get(dniSocio);
            var unaCuota = new Cuota(DateTime.Today.Date, pDescripcion, pMonto, pMes, pAño, unSocio);

            unSocio.Cuotas.Add(unaCuota);
        }

        /// <summary>
        /// Genera las cuotas de todos aquellos socios activos.
        /// </summary>
        public void AltaAutomaticaCuota()
        {
            var sociosActivos = (List<Socio>)this.iUnitOfWork.SocioRepository.GetSociosActivos();
            string pMes = DateTime.Today.Month.ToString();
            int pAño = DateTime.Today.Year;
            Cuota unaCuota;

            foreach (Socio pSocio in sociosActivos)
            {
                if (!pSocio.Cuotas.Exists(pCuota => pCuota.Mes == pMes && pCuota.Año == pAño))
                {
                    unaCuota = new Cuota(DateTime.Today.Date, "Cuota correspondiente al periodo " + pMes + "/" + pAño + ".", 450, pMes, pAño, pSocio);
                    pSocio.Cuotas.Add(unaCuota);
                }
            }
        }

        /// <summary>
        /// Devuelve una cuota
        /// </summary>
        /// <param name="nroCuota"></param>
        /// <returns></returns>
        public IList<Cuota> BuscarCuotas(int dniSocio)
        {
            var adminSocio = new ControladorSocio();

            var unSocio = adminSocio.GetSocioByDni(dniSocio);
            return unSocio.Cuotas;
        }

        /// <summary>
        /// Elimina una cuota
        /// </summary>
        /// <param name="dniSocio"></param>
        /// <param name="nroCuota"></param>
        public void BajaCuota(int dniSocio, int nroCuota)
        {
            
            var listaCuota = (List<Cuota>)this.BuscarCuotas(dniSocio);
            var unaCuota = listaCuota.Find(pCuota => pCuota.NroCuota == nroCuota);

            this.iUnitOfWork.CuotaRepository.Remove(unaCuota);
        }

        /// <summary>
        /// Devuelve una lista con todas las cuotas impagas hasta la fecha
        /// </summary>
        /// <returns></returns>
        public IList<Cuota> CuotasImpagas()
        {
            List<Cuota> listaCuotas = new List<Cuota>();

            foreach (var unaCuota in this.iUnitOfWork.CuotaRepository.GetAll())
            {
                if (!unaCuota.Pagada)                
                    listaCuotas.Add(unaCuota);                
            }

            return listaCuotas;
        }

        /// <summary>
        /// Devuelve una lista con todas las cutoas impagas de un socio hasta la fecha
        /// </summary>
        /// <param name="dniSocio"></param>
        /// <returns></returns>
        public IList<Cuota> CuotasImpagas(int dniSocio)
        {
            var adminSocio = new ControladorSocio();
            List<Cuota> listaCuotas = new List<Cuota>();

            foreach (var unaCuota in adminSocio.GetCuotasSocio(dniSocio))
            {
                if (!unaCuota.Pagada)
                    listaCuotas.Add(unaCuota);
            }

            return listaCuotas;
        }

        /// <summary>
        /// Genera el pago de una cuota.
        /// </summary>
        /// <param name="dniSocio"></param>
        /// <param name="nroCuota"></param>
        /// <param name="importe"></param>
        public void AltaPagoCuota(int dniSocio,int nroCuota, float importe)
        {
            var listaCuota = (List<Cuota>)this.BuscarCuotas(dniSocio);
            var unaCuota = listaCuota.Find(pCuota => pCuota.NroCuota == nroCuota);

            Pago unPago = new Pago(unaCuota, DateTime.Today.Date, importe);

            unaCuota.Pagos.Add(unPago);
            unaCuota.Cancelada();
        }

        /// <summary>
        /// Elimina un pago de la cuota.
        /// Solo en situaciones por si se llega a equivocar poniendo el monto.
        /// </summary>
        /// <param name="dniSocio"></param>
        /// <param name="nroCuota"></param>
        /// <param name="importe"></param>
        public void BajaPagoCuota(int dniSocio, int nroCuota, float importe)
        {
            var listaCuota = (List<Cuota>)this.BuscarCuotas(dniSocio);
            var unaCuota = listaCuota.Find(pCuota => pCuota.NroCuota == nroCuota);

            Pago unPago = new Pago(unaCuota, DateTime.Today.Date, importe);

            unaCuota.Pagos.Remove(unPago);
        }
    }
}
