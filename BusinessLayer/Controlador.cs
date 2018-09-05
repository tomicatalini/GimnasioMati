using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DataBase;
using DataLayer;
using DomainLayer;

namespace BusinessLayer
{
    public class Controlador
    {
        //Contexto de base de datos
        private GymMatiContext dbMati;

        public Controlador(GymMatiContext db)
        {
            //Inicializa la base de datos
            this.dbMati = db;
        }

        public void guardarCambios()
        {
            //Realiza el commit a la base de datos
            this.dbMati.SaveChanges();
        }

        public SocioDTO buscarSocio(int dni)
        {
            //Socio unSocio = new Socio();
            //unSocio.
            //Busca un socio dentro del DbSet con coincidencia en dni
            SocioDTO socioBuscado = this.dbMati.Socios.Where(s => s.DNI == dni).Single();

            return socioBuscado;

        }

        public bool existeSocio(int dni)
        {
            if (this.dbMati.Socios.Where(s => s.DNI == dni).Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void altaSocio(long dni, string nombre, string apellido, DateTime fechaNac, string domicilio, int telefono, string mail)
        {
            
            SocioDTO unSocio = new SocioDTO()
            {
                DNI = dni,
                Nombre = nombre,
                Apellido = apellido,
                FechaNac = fechaNac,
                Domicilio = domicilio,
                Telefono = telefono,
                Mail = mail
            };
                       
             //Agrega el nuevo socio al DbSet
             this.dbMati.Socios.Add(unSocio);
           
        }

        public void bajaSocio(int dni)
        {
            //Se busca el socio a eliminar
            SocioDTO remSocio = this.buscarSocio(dni);

            //Se elimina el socio
            this.dbMati.Socios.Remove(remSocio);
        }

        
        
        public void modificarSocio(int dni, string nombre, string apellido, DateTime fechaNac, string domicilio, int telefono, string mail)
        {
           
            //Dar de Baja el Socio
            this.bajaSocio(dni);

            //Dar de Alta el Socio
            this.altaSocio(dni, nombre, apellido, fechaNac, domicilio, telefono, mail);
        }

        
    }
}
