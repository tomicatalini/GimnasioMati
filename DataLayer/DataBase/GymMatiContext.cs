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
        
        //Repositorio de Socios
        public DbSet<SocioDTO> Socios { get; set; }

        //Configuracion de mapeo
        protected override void OnModelCreating(DbModelBuilder pModelBuilder)
        {
            //Configuracion de un Socio, tanto en tabla como en relaciones
            pModelBuilder.Configurations.Add(new SocioMap());
            pModelBuilder.Configurations.Add(new CuotaMap());
            pModelBuilder.Configurations.Add(new PagoMap());

            base.OnModelCreating(pModelBuilder);
        }
    }
}
