using System.Data.Entity.ModelConfiguration;
using DomainLayer;

namespace DataLayer.Mapping
{
    class SocioMap : EntityTypeConfiguration<Socio>
    {
        //unSocio => unSocio
        public SocioMap()
        {
            //Nombre de la tabla
            this.ToTable("Socio");

            //Declaracion de clave primaria sobre el campo dni. Esta propiedad (nroSocio) se le especifica un nombre a la columna y que es NOT NULL (IsRequired)
            this.HasKey(unSocio => unSocio.NroSocio)
                .Property(unSocio => unSocio.NroSocio)
                    .HasColumnName("nroSocio")
                    .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                    .IsRequired();
            //conf. propiedad nroSocio: nombre y not null
            this.Property(unSocio => unSocio.NroSocio)
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
            this.Property(unSocio => unSocio.FecNacimiento)
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

            ////Relacion de uno a muchos entre socio y cuotas
            this.HasMany(unSocio => unSocio.Cuotas)
                .WithRequired(unaCuota => unaCuota.Socio)
                    .HasForeignKey<int>(unaCuota => unaCuota.SocioDNI);

            ////Relacion de muchos a muchos entre socio y rutinas. 
            ////Se hace una tabla intermedia llamada "socioRutina" con las columas SocioDNI y rutinaId.
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
