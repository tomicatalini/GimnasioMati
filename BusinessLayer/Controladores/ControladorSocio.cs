using System;
using System.Collections.Generic;
using DataLayer;
using DataLayer.DataBase;
using DomainLayer;

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
        public Socio GetSocioByDni(int pDni)
        {
            var unSocio = this.iUnitOfWork.SocioRepository.Get(pDni);

            //Verifica la existencia del socio.
            //if (unSocio is null)
            //    throw new NullReferenceException("El socio ingresado no existe");
            
            return unSocio;           
        }

        public Socio GetSocioByNroSocio(int codigo)
        {
            var unSocio = this.iUnitOfWork.SocioRepository.Get(codigo);

            //Verifica la existencia del socio.
            //if (unSocio is null)
            //    throw new NullReferenceException("El socio ingresado no existe");

            return unSocio;
        }

        /// <summary>
        /// Devuelve los socios donde su apellido contenga la cadena pasada como parametro.
        /// </summary>
        /// <param name="pApellido"></param>
        /// <returns></returns>
        public IList<Socio> GetSociosByApellido(string pApellido)
        {
            return this.iUnitOfWork.SocioRepository.GetSociosByString(pApellido);
        }

        public IList<Cuota> GetCuotasSocio(int dniSocio)
        {
            return this.GetSocioByDni(dniSocio).Cuotas;
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
        public void AltaSocio(int pDni, string pNombre, string pApellido, DateTime pFechaNacimiento, string pDomicilio, long pTelefono, string pMail)
        {

            Socio unSocio = new Socio(pDni, pNombre, pApellido, pFechaNacimiento, pDomicilio, pTelefono, pMail);
            
            this.iUnitOfWork.SocioRepository.Add(unSocio);
        }

        /// <summary>
        /// Baja de un socio
        /// </summary>
        /// <param name="dni"></param>
        public void BajaSocio(int pDni)
        {
            var unSocio = this.GetSocioByDni(pDni);            
            
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
        public void ModificarSocio(int pDni, string pNombre, string pApellido, DateTime pFechaNacimiento, string pDomicilio, long pTelefono, string pMail)
        {
            //Se obtiene la referencia del socio que se quiere cambiar
            var unSocio = this.GetSocioByDni(pDni);

            //Se realizan las modificaciones
            unSocio.Nombre = pNombre;
            unSocio.Apellido = pApellido;
            unSocio.FecNacimiento = pFechaNacimiento;
            unSocio.Domicilio = pDomicilio;
            unSocio.Telefono = pTelefono;
            unSocio.Mail = pMail;
            
            //Para el caso de "Dar de alta" un socio en estado inactivo
            //unSocio.Activo = pActivo;
        }

        /// <summary>
        /// Realiza un commit a la bd.
        /// </summary>
        public void GuardarCambios()
        {
            this.iUnitOfWork.Complete();
        }

        /// <summary>
        /// Cambia el estadod de un socio inactivo
        /// </summary>
        /// <param name="pDni"></param>
        public void AltaSocioBaja(int pDni)
        {
            var unSocio = this.GetSocioByDni(pDni);
            unSocio.Activo = true;
        }
    }

}
