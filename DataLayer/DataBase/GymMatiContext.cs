using System.Data.Entity;
using DataLayer.Mapping;

namespace DataLayer.DataBase
{
    public class GymMatiContext : DbContext
    {

        //Contructor de la clase
        public GymMatiContext() : base()
        {
            //Crea la base de datos en caso de no existir
            Database.SetInitializer<GymMatiContext>(new CreateDatabaseIfNotExists<GymMatiContext>());

            //Elimina la base de datos si cambio el modelo. Luego la crea nuevamente, con los cambios correspondientes
            Database.SetInitializer<GymMatiContext>(new DropCreateDatabaseIfModelChanges<GymMatiContext>());
        }
        
        //Repositorios
        public DbSet<SocioDTO> Socios { get; set; }
        public DbSet<CuotaDTO> Cuotas { get; set; }
        public DbSet<PagoDTO> Pagos { get; set; }
        public DbSet<RutinaDTO> Rutinas { get; set; }
        public DbSet<FichaMedicaDTO> FichasMedicas { get; set; }

        //Configuracion de mapeo
        protected override void OnModelCreating(DbModelBuilder pModelBuilder)
        {
            //Configuracion de un Socio, tanto en tabla como en relaciones
            pModelBuilder.Configurations.Add(new SocioMap());

            //Modulo Cuota
            pModelBuilder.Configurations.Add(new CuotaMap());
            pModelBuilder.Configurations.Add(new PagoMap());
            
            //Modulo Rutinas
            pModelBuilder.Configurations.Add(new RutinaMap());
            pModelBuilder.Configurations.Add(new DetalleRutinaMap());
            pModelBuilder.Configurations.Add(new MusculoMap());
            pModelBuilder.Configurations.Add(new EjercicioMap());

            //Modulo Ficha Medica
            pModelBuilder.Configurations.Add(new FichaMedicaMap());
            pModelBuilder.Configurations.Add(new ActividadFisicaMap());
            pModelBuilder.Configurations.Add(new ContactoEmergenciaMap());
            pModelBuilder.Configurations.Add(new EnfermedadMap());
            pModelBuilder.Configurations.Add(new LimitacionFisicaMap());
            pModelBuilder.Configurations.Add(new MedicacionMap());
            pModelBuilder.Configurations.Add(new OperacionMap());

            //Modulo movimiento
            pModelBuilder.Configurations.Add(new MovimientoMap());
            pModelBuilder.Configurations.Add(new LineaMovimientoMap());
            pModelBuilder.Configurations.Add(new ProductoMap());
            pModelBuilder.Configurations.Add(new TipoProductoMap());

            //Gasto Administrativo
            pModelBuilder.Configurations.Add(new GastoAdministrativoMap());

            base.OnModelCreating(pModelBuilder);
        }
    }
}
