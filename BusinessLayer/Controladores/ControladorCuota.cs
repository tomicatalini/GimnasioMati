using System;
using System.Collections.Generic;
using DataLayer;
using DataLayer.DataBase;

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
        public void AltaCuota(DateTime pFechaEmision,MesDTO pMes, int pAño, string pDescripcion, float pMonto)
        {

            CuotaDTO unaCuota = new CuotaDTO
            {
                NroCuota = 1,
                FechaEmision = pFechaEmision,
                Mes = pMes,
                Año = pAño,
                Descripcion = pDescripcion,
                Monto = pMonto,
                Pagada = false
            };

            this.iUnitOfWork.CuotaRepository.Add(unaCuota);
        }

        public void AltaAutomaticaCuota(long pDni)
        {
            //           
        }
    }
}
