using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DataBase;
using DomainLayer;

namespace BusinessLayer.Controladores
{
    class ControladorRutina
    {
        private UnitOfWork iUnitOfWork;

        public ControladorRutina() // constructor del controlador
        {
            this.iUnitOfWork = new UnitOfWork(new GymMatiContext());
        }

        public void NuevoEjercicio(string nombre) // constructor de ejercicio
        {
            var unEjercicio = new Ejercicio(nombre); // instanciacion de nuevo ejercicio
            this.iUnitOfWork.EjercicioRepository.Add(unEjercicio); // agregarEjercicio a listEjercicios
        }

        public void NuevoMusculo(string nombre) // constructor de musculo
        {
            var unMusculo = new Musculo(nombre); // instanciacion de nuevo musculo
            this.iUnitOfWork.MusculoRepository.Add(unMusculo); // agregarMusculo a listMusculo
        }

        public LineaEjercicio NuevaLineaEjercicio( int musculoId, int ejercicioId, string serieRepeticion, int descanso) // agregar "renglon" de ejercicio
        {
            var unMusculo = this.iUnitOfWork.MusculoRepository.Get(musculoId); // obtener musculo del repositorio
            var unEjercicio = this.iUnitOfWork.EjercicioRepository.Get(ejercicioId); // obtener ejercicio del repositorio

            LineaEjercicio unaLinea = new LineaEjercicio(unMusculo, unEjercicio, serieRepeticion, descanso); // cargar musculo y ejercicio en lineaEjercicio
            return unaLinea;
        }

        public DetalleRutina NuevoDetalleRutina(int dia, Rutina unaRutina, string serieRepeticion, int descanso) // constructor de "renglones" de rutina"
        {
            var unDetalleRutina = new DetalleRutina(dia, serieRepeticion, descanso, unaRutina);

            return unDetalleRutina;
        }

        /*public Rutina AltaRutina(string nombre, int duracion, DateTime fechaInicio)
        {
            var unaRutina = new Rutina(nombre, duracion, fechaInicio);
            return unaRutina;
        } */

        public IList<Rutina> BuscarRutina(string nombre)
        {
            return this.iUnitOfWork.RutinaRepository.GetByNombre(nombre);
        }

        public void BajaRutina(int rutinaId)
        {
            var unaRutina = this.iUnitOfWork.RutinaRepository.Get(rutinaId);

            this.iUnitOfWork.RutinaRepository.Remove(unaRutina);
        }

        public void ModificarRutina(int rutinaId, string nombre, int duracion, DateTime fechaInicio)
        {
            var unaRutina = this.iUnitOfWork.RutinaRepository.Get(rutinaId);

            unaRutina.Nombre = nombre;
            unaRutina.CantDias = duracion;
            unaRutina.FecInicio = fechaInicio;

            /*for (i = 0 , i <= listaRutinas.lienght(), i++ ){
                if (listaRutinas[i].id = rutinaId){
                    listaRutinas[i].SetNombre(nombre);
                    listaRutinas[i].SetCantDias(duracion);
                    listaRutinas[i].FecInicio(fechaInicio);
                }
            } */
            
        }

        public void AsociarRutinaASocio(int rutinaId, int socioDni)
        {

            var unaRutina = this.iUnitOfWork.RutinaRepository.Get(rutinaId);
            var unSocio = this.iUnitOfWork.SocioRepository.Get(socioDni);

            unSocio.Rutinas.Add(unaRutina);
            unaRutina.Socios.Add(unSocio);
        }

        public void AltaRutina()
        {
            ControladorRutina adminRutina = new ControladorRutina();
            var unaRutina = adminRutina.AltaRutinaActividad(nombre, duracion, fechaInicio, dniSocio);

            foreach (var tabla in dataGriedViews)
            {

                var unDetalleRutina = adminRutina.NuevoDetalleRutina(dia, unaRutina);

                foreach (var fila in tabla.Rows)
                {
                    var lineaEjercicio = adminRutina.NuevaLineaEjercicio(musculoId, ejercicioId, serieRepeticion, descanso);
                    unDetalleRutina.LineasEjercicio.Add(lineaEjercicio);
                }

                unaRutina.DetallesRutina.Add(unDetalleRutina);
            }

            this.iUnitOfWork.RutinaRepository.Add(unaRutina);
        }
    }
}
