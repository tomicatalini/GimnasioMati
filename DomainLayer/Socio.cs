using System;
using System.Collections.Generic;

namespace DomainLayer
{
    public class Socio
    {
        
        /// <summary>
        /// Dni del socio
        /// </summary>
        public long DNI { get; set; }

        /// <summary>
        /// Nombre del socio
        /// </summary>
        public string nombre { get; set; }

        /// <summary>
        /// Apellido del socio
        /// </summary>
        public string apellido { get; set; }

        /// <summary>
        /// Fecha de nacimiento del socio
        /// </summary>
        public DateTime fecNacimiento { get; set; }

        /// <summary>
        /// Domicilio actual del socio
        /// </summary>
        public string domicilio { get; set; }

        /// <summary>
        /// Telefono actual del socio
        /// </summary>
        public long telefono { get; set; }

        /// <summary>
        /// Correo electronico del socio
        /// </summary>
        public string mail { get; set; }

        /// <summary>
        /// Propiedad que hace referencia a si un socio esta activo o inactivo.
        /// </summary>
        public bool activo { get; set; }

        /// <summary>
        /// Historial de rutinas asociadas al socio
        /// </summary>
        public IList<Rutina> Rutinas { get; set; }

        /// <summary>
        /// Historial de cuotas asociadas al socio
        /// </summary>
        public IList<Cuota> Cuotas { get; set; }

        /// <summary>
        /// Historial medico del socio
        /// </summary>
        public IList<HistorialMedico> historialMedico { get; set; }

        
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="pDni"></param>
        /// <param name="pNombre"></param>
        /// <param name="pApellido"></param>
        /// <param name="pFecNacimiento"></param>
        /// <param name="pDomicilio"></param>
        /// <param name="pTelefono"></param>
        /// <param name="pMail"></param>
        public Socio(long pDni, string pNombre, string pApellido, DateTime pFecNacimiento, string pDomicilio ,long pTelefono, string pMail)
        {

            this.DNI = pDni;
            this.apellido = pApellido;
            this.nombre = pNombre;
            this.fecNacimiento = pFecNacimiento;
            this.domicilio = pDomicilio;
            this.telefono = pTelefono;
            this.mail = pMail;
            this.activo = true;

        }
        
        

    }
}
