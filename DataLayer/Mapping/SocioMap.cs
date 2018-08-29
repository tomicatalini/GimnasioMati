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
            this.HasKey(unSocio => unSocio.DNI)
                .Property(unSocio => unSocio.DNI)
                    .HasColumnName("dni")
                    .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                    .IsRequired();

            //conf. propiedad nombre: nombre, not null y longitud maxima de 40 caracteres
            this.Property(unSocio => unSocio.Nombre)
                    .IsRequired()
                    .HasMaxLength(40);

            //conf. propiedad apellido: nombre, not null y longitud maxima de 40 caracteres
            this.Property(unSocio => unSocio.Apellido)
                    .IsRequired()
                    .HasMaxLength(40);

            //conf. propiedad fecha nacimiento: nombre y not null
            this.Property(unSocio => unSocio.FechaNac)
                    .IsRequired();

            //conf. propiedad telefono: nombre y not null
            this.Property(unSocio => unSocio.Telefono)
                    .IsRequired();

            //conf. propiedad domicilio: nombre y nullable
            this.Property(unSocio => unSocio.Domicilio)
                    .HasColumnName("domicilio")
                    .IsOptional();

            //conf. propiedad mail: nombre y nulleable
            this.Property(unSocio => unSocio.Mail)
                   .HasColumnName("mail")
                   .IsOptional();

            //Relacion de uno a muchos entre socio y cuotas
            this.HasMany(unSocio => unSocio.Cuotas)
                .WithRequired(unaCuota => unaCuota.Socio)
                    .HasForeignKey<long>(unaCuota => unaCuota.socioDNI);

            //Relacion de muchos a muchos entre socio y rutinas. 
            //Se hace una tabla intermedia llamada "socioRutina" con las columas SocioDNI y rutinaId.
            this.HasMany(unSocio => unSocio.Rutinas)
                .WithMany(unaRutina => unaRutina.Socios)
                    .Map(pMapping =>
                                    {
                                        pMapping.ToTable("socioRutina");
                                        pMapping.MapLeftKey("socioDNI");
                                        pMapping.MapRightKey("rutinaId");
                                    });

            //Relacion de uno a muchos con ficha medica (Historial medico)            
             this.HasMany(unSocio => unSocio.HistorialMedico)
                 .WithRequired(unaFicha => unaFicha.Socio)
                    .HasForeignKey(unaFicha => unaFicha.SocioDNI);
                    

        }
    }
}
