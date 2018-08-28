using System.Data.Entity.ModelConfiguration;

namespace DataLayer.Mapping
{
    class SocioMap : EntityTypeConfiguration<SocioDTO>
    {
        //unSocio => unSocio
        public SocioMap()
        {
            //Nombre de la tabla
            this.ToTable("Socio");

            //Declaracion de clave primaria sobre el campo dni. Esta propiedad (dni) se le especifica un nombre a la columna y que es NOT NULL (IsRequired)
            this.HasKey(unSocio => unSocio.dni)
                .Property(unSocio => unSocio.dni)
                    .HasColumnName("dni")
                    .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
                    .IsRequired();

            //conf. propiedad nombre: nombre, not null y longitud maxima de 40 caracteres
            this.Property(unSocio => unSocio.nombre)
                    .IsRequired()
                    .HasMaxLength(40);

            //conf. propiedad apellido: nombre, not null y longitud maxima de 40 caracteres
            this.Property(unSocio => unSocio.apellido)
                    .IsRequired()
                    .HasMaxLength(40);

            //conf. propiedad fecha nacimiento: nombre y not null
            this.Property(unSocio => unSocio.fechaNac)
                    .IsRequired();

            //conf. propiedad telefono: nombre y not null
            this.Property(unSocio => unSocio.telefono)
                    .IsRequired();

            //conf. propiedad domicilio: nombre y nullable
            this.Property(unSocio => unSocio.domicilio)
                    .HasColumnName("domicilio")
                    .IsOptional();

            //conf. propiedad mail: nombre y nulleable
            this.Property(unSocio => unSocio.mail)
                   .HasColumnName("mail")
                   .IsOptional();
            
            //Relacion de uno a muchos entre socio y cuotas
            this.HasMany(unSocio => unSocio.Cuotas)
                .WithRequired(unaCuota => unaCuota.socio)
                .Map(pMapping => pMapping.MapKey("socio"));

            //Relacion de muchos a muchos entre socio y rutinas. Se hace una tabla intermedia llamada "socioRutina" con las columas RuntinaID y SocioDNI
            this.HasMany(unSocio => unSocio.Rutinas)
                .WithMany(unaRutina => unaRutina.Socios)
                .Map(pMapping => pMapping.ToTable("socioRutina")
                                            .MapLeftKey("rutina")
                                            .MapRightKey("socio"));

            //Relacion de uno a muchos entre socio y ficha medica
            this.HasMany(unSocio => unSocio.HistorialMedico)
                .WithRequired(unaFicha => unaFicha.socio)
                .Map(pMapping => pMapping.MapKey("socio"));

        }
    }
}
