using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Mapping
{
    class EjercicioMap : EntityTypeConfiguration<EjercicioDTO>
    {
        public EjercicioMap()
        {
            //nombre de la tabla en base de datos
            this.ToTable("Ejercicio");

            //conf. clave primaria: nombre, auto-increment y not null
            this.HasKey(unEjercicio => unEjercicio.Id)
                .Property(unEjercicio => unEjercicio.Id)
                    .HasColumnName("ejercicioId")
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                    .IsRequired();

            //conf. propiedad nombre: nombre y not null
            this.Property(unEjercicio => unEjercicio.Nombre)
                    .HasColumnName("nombre")
                    .IsRequired();

            //relacion de uno a muchos con musculo
            /*
            this.HasRequired(unEjercicio => unEjercicio.Musculo)
                .WithMany(unMusculo => unMusculo.Ejercicios)
                    .Map(pMap => pMap.MapKey("musculo"));
                    */
        }
    }
}
