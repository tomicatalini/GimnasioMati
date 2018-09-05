using System;
using System.Collections.Generic;
using DataLayer;
using DataLayer.DataBase;

namespace BusinessLayer.Controladores
{
    public class ControladorSocio
    {
        /// <summary>
        /// Contexto de base de datos junto con el patron UnitOfWork
        /// </summary>
        private UnitOfWork iUnitOfWork;

        /// <summary>
        /// Constructor
        /// </summary>
        public ControladorSocio()
        {
            this.iUnitOfWork = new UnitOfWork(new GymMatiContext());
        }

        /// <summary>
        /// Busca un socio a traves de su dni
        /// </summary>
        /// <param name="pDni"></param>
        /// <returns> un socio </returns>
        public SocioDTO BuscarSocio(int pDni)
        {
            if (!this.iUnitOfWork.SocioRepository.Exist(pDni))
                throw new KeyNotFoundException("El socio ingresado no existe");

            var unSocio = this.iUnitOfWork.SocioRepository.Get(pDni);

            //Verifica si el socio ya existe, pero se encuentra en estado de Baja.
            if (this.EstadoSocio(pDni) == false)
                throw new Exception("El socio esta en estado de Baja");

            return unSocio;           
        }

        /// <summary>
        /// Alta de un nuevo socio
        /// </summary>
        /// <param name="pDni"></param>
        /// <param name="pNombre"></param>
        /// <param name="pApellido"></param>
        /// <param name="pFechaNacimiento"></param>
        /// <param name="pDomicilio"></param>
        /// <param name="pTelefono"></param>
        /// <param name="pMail"></param>
        public void AltaSocio(int pDni, string pNombre, string pApellido, DateTime pFechaNacimiento, string pDomicilio, int pTelefono, string pMail)
        {
            var unSocio = this.iUnitOfWork.SocioRepository.Get(pDni);

            //Verifica si el socio ya existe, pero se encuentra en estado de Baja.
            if (this.EstadoSocio(pDni) == false)
                throw new Exception("El socio esta en estado de Baja");

            SocioDTO otroSocio = new SocioDTO()
            {
                DNI = pDni,
                Nombre = pNombre,
                Apellido = pApellido,
                FechaNac = pFechaNacimiento,
                Domicilio = pDomicilio,
                Telefono = pTelefono,
                Mail = pMail,
                Activo = true
            };
            
            this.iUnitOfWork.SocioRepository.Add(otroSocio);

        }

        /// <summary>
        /// Baja de un socio
        /// </summary>
        /// <param name="dni"></param>
        public void BajaSocio(int pDni)
        {
            if (!this.iUnitOfWork.SocioRepository.Exist(pDni))
                throw new KeyNotFoundException("El socio ingresado no existe");
            
            SocioDTO unSocio = this.BuscarSocio(pDni);
            unSocio.Activo = false;
        }

        /// <summary>
        /// Modifica los datos de un socio
        /// </summary>
        /// <param name="pDni"></param>
        /// <param name="pNombre"></param>
        /// <param name="pApellido"></param>
        /// <param name="pFechaNacimiento"></param>
        /// <param name="pDomicilio"></param>
        /// <param name="pTelefono"></param>
        /// <param name="pMail"></param>
        public void modificarSocio(int pDni, string pNombre, string pApellido, DateTime pFechaNacimiento, string pDomicilio, int pTelefono, string pMail)
        {

            if (!this.iUnitOfWork.SocioRepository.Exist(pDni))
                throw new KeyNotFoundException("El socio ingresado no existe");

            //Se obtiene la referencia del socio que se quiere cambiar
            var unSocio =this.iUnitOfWork.SocioRepository.Get(pDni);

            //Se realizan las modificaciones
            unSocio.Nombre = pNombre;
            unSocio.Apellido = pApellido;
            unSocio.FechaNac = pFechaNacimiento;
            unSocio.Domicilio = pDomicilio;
            unSocio.Telefono = pTelefono;
            unSocio.Mail = pMail;
        }

        /// <summary>
        /// Determina si un socio esta activo o no.
        /// </summary>
        /// <param name="pDni"></param>
        /// <returns></returns>
        public bool EstadoSocio(int pDni)
        {
            var unSocio = this.iUnitOfWork.SocioRepository.Get(pDni);

            return unSocio.Activo;
        }
    }

}
