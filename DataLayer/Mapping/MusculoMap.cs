using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Mapping
{
    class MusculoMap : EntityTypeConfiguration<MusculoDTO>
    {
        public MusculoMap()
        {
            //nombre de la tabla en base de datos
            this.ToTable("Musculo");

            //conf. clave primaria: nombre, autoincrement y not null
            this.HasKey(unMusculo => unMusculo.Id)
                .Property(unMusculo => unMusculo.Id)
                    .HasColumnName("musculoId")
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                    .IsRequired();

            //conf. propiedad nombre: nombre y not null
            this.Property(unMusculo => unMusculo.Nombre)
                    .HasColumnName("nombre")
                    .IsRequired();

            //relacion de muchos a uno con detalle rutina
            this.HasMany(unMusculo => unMusculo.DetallesDeRutina)
                .WithRequired(unDetalle => unDetalle.Musculo)
                    .HasForeignKey(unDetalle => unDetalle.MusculoId);

            //relacion de muchos a uno con ejercicio
            this.HasMany(unMusculo => unMusculo.Ejercicios)
                .WithRequired(unEjercicio => unEjercicio.Musculo)
                    .HasForeignKey(unEjercicio => unEjercicio.MusculoId);

        }
    }
}
