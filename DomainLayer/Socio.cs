using System;
using System.Collections.Generic;

namespace DomainLayer
{
    public class Socio
    {

        /// <summary>
        /// Numero de socio
        /// </summary>
        public int NroSocio { get; set; }
        
        /// <summary>
        /// Dni del socio
        /// </summary>
        public int DNI { get; set; }

        /// <summary>
        /// Nombre del socio
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Apellido del socio
        /// </summary>
        public string Apellido { get; set; }

        /// <summary>
        /// Fecha de nacimiento del socio
        /// </summary>
        public DateTime FecNacimiento { get; set; }

        /// <summary>
        /// Domicilio actual del socio
        /// </summary>
        public string Domicilio { get; set; }

        /// <summary>
        /// Telefono actual del socio
        /// </summary>
        public long Telefono { get; set; }

        /// <summary>
        /// Correo electronico del socio
        /// </summary>
        public string Mail { get; set; }

        /// <summary>
        /// Propiedad que hace referencia a si un socio esta activo o inactivo.
        /// </summary>
        public bool Activo { get; set; }

        /// <summary>
        /// Historial de rutinas asociadas al socio
        /// </summary>
        public virtual IList<Rutina> Rutinas { get; set; }

        /// <summary>
        /// Historial de cuotas asociadas al socio
        /// </summary>
        public virtual List<Cuota> Cuotas { get; set; }

        /// <summary>
        /// Historial medico del socio
        /// </summary>
        public virtual IList<FichaMedica> HistorialMedico { get; set; }

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Socio(){}
        
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
        public Socio(int pDni, string pNombre, string pApellido, DateTime pFecNacimiento, string pDomicilio ,long pTelefono, string pMail)
        {

            this.DNI = pDni;
            this.Apellido = pApellido;
            this.Nombre = pNombre;
            this.FecNacimiento = pFecNacimiento;
            this.Domicilio = pDomicilio;
            this.Telefono = pTelefono;
            this.Mail = pMail;
            this.Activo = true;

            this.Cuotas = new List<Cuota>();
            this.Rutinas = new List<Rutina>();
            this.HistorialMedico = new List<FichaMedica>();

        }
    }
}
