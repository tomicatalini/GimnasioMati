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
        //private UnitOfWork iUnitOfWork;

        //public ControladorRutina()
        //{
        //    this.iUnitOfWork = new UnitOfWork(new GymMatiContext());
        //}

        //public void NuevoEjercicio(string nombre)
        //{
        //    var unEjercicio = new Ejercicio(nombre);
        //    this.iUnitOfWork.EjercicioRepository.Add(unEjercicio);
        //}

        //public void NuevoMusculo(string nombre)
        //{
        //    var unMusculo = new Musculo(nombre);
        //    this.iUnitOfWork.MusculoRepository.Add(unMusculo);
        //}

        //public LineaEjercicio NuevaLineaEjercicio( int musculoId, int ejercicioId, string serieRepeticion, int descanso)
        //{
        //    var unMusculo = this.iUnitOfWork.MusculoRepository.Get(musculoId);
        //    var unEjercico = this.iUnitOfWork.EjercicioRepository.Get(ejercicioId);

        //    LineaEjercicio unaLinea = new LineaEjercicio(unMusculo, unEjercico, serieRepeticion, descanso);
        //    return unaLinea;
        //}

        //public DetalleRutina NuevoDetalleRutina(int dia, Rutina unaRutina)
        //{
        //    var unDetalleRutina = new DetalleRutina(dia, unaRutina);

        //    return unDetalleRutina;            
        //}


        //public Rutina AltaRutinaActividad(string nombre, int duracion, DateTime fechaInicio, int dniSocio)
        //{

        //    ControladorSocio adminSocio = new ControladorSocio();

        //    var unSocio = adminSocio.GetSocioByDni(dniSocio);
        //    var unaRutina = new Rutina(nombre, duracion, fechaInicio);
        //    unSocio.Rutinas.Add(unaRutina);
        //    unaRutina.Socios.Add(unSocio);

        //    return unaRutina;
        //}

        //public IList<Rutina> BuscarRutina(string nombre)
        //{
        //    return this.iUnitOfWork.RutinaRepository.GetByNombre(nombre);
        //}

        //public void BajaRutinaActividad(int rutinaId)
        //{
        //    var unaRutina = this.iUnitOfWork.RutinaRepository.Get(rutinaId);

        //    this.iUnitOfWork.RutinaRepository.Remove(unaRutina);
        //}

        //public void ModificarRutinaActividad()
        //{

        //}

        //public void AsociarRutinaASocio(int rutinaId, int socioDni)
        //{

        //    var unaRutina = this.iUnitOfWork.RutinaRepository.Get(rutinaId);
        //    var unSocio = this.iUnitOfWork.SocioRepository.Get(socioDni);

        //    unSocio.Rutinas.Add(unaRutina);
        //    unaRutina.Socios.Add(unSocio);
        //}

        //public void AltaRutina()
        //{
        //    ControladorRutina adminRutina = new ControladorRutina();
        //    var unaRutina = adminRutina.AltaRutinaActividad(nombre, duracion, fechaInicio, dniSocio);

        //    foreach (var tabla in dataGriedViews)
        //    {

        //        var unDetalleRutina = adminRutina.NuevoDetalleRutina(dia, unaRutina);

        //        foreach (var fila in tabla.Rows)
        //        {
        //            var lineaEjercicio = adminRutina.NuevaLineaEjercicio(musculoId, ejercicioId, serieRepeticion, descanso);
        //            unDetalleRutina.LineasEjercicio.Add(lineaEjercicio);
        //        }

        //        unaRutina.DetallesRutina.Add(unDetalleRutina);
        //    }

        //    this.iUnitOfWork.RutinaRepository.Add(unaRutina);
        //}
    }
}
