using System;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Mapping
{
    class RutinaMap : EntityTypeConfiguration<RutinaDTO>
    {
        public RutinaMap()
        {
            //Nombre de la tabla en base de datos
            this.ToTable("Rutina");

            //conf. clave primaria: nombre, autoincrement y not null
            this.HasKey<int>(unaRutina => unaRutina.Id)
                .Property(unaRutina => unaRutina.Id)
                    .HasColumnName("nroRutina")
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                    .IsRequired();

            //conf. propiedad nombre: nombre y not null
            this.Property(unaRutina => unaRutina.Nombre)
                    .HasColumnName("nombre")
                    .IsRequired();

            //conf. propiedad cantidad de dias: nombre y not null
            this.Property(unaRutina => unaRutina.CantDias)
                    .HasColumnName("dias")
                    .IsRequired();

            //conf. propiedad fecha de inicio: nombre y not null
            this.Property(unaRutina => unaRutina.FechaInicio)
                    .HasColumnName("fechaInicio")
                    .IsRequired();

            //relacion de muchos a muchos con socio
            this.HasMany(unaRutina => unaRutina.Socios)
                .WithMany(unSocio => unSocio.Rutinas)
                    .Map(pMap => pMap.MapLeftKey("rutina")
                                     .MapRightKey("socio"));

            //relacion de uno a muchos con detalle rutina
            this.HasMany(unaRutina => unaRutina.DetalleRutinas)
                .WithRequired(unDetalle => unDetalle.Rutina)
                    .Map(pMap => pMap.MapKey("rutina"));
        }
    }
}
