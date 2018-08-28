using System;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Mapping
{
    class FichaMedicaMap : EntityTypeConfiguration<FichaMedicaDTO>
    {
        public FichaMedicaMap()
        {

            //Nombre de la tabla en base de datos
            this.ToTable("FichaMedica");

            //conf. clave primaria: nombre, no auto incremental y not null.. elegi como clave la fecha
            this.HasKey<DateTime>(unaFicha => unaFicha.fechaEntrega)
                .Property(unaFicha => unaFicha.fechaEntrega)
                    .HasColumnName("fechaEntrega")
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                    .IsRequired();

            //conf. propiedad peso: nombre y not null
            this.Property(unaFicha => unaFicha.peso)
                    .HasColumnName("peso")
                    .IsRequired();

            //conf. propiedad altura: nombre y not null
            this.Property(unaFicha => unaFicha.altura)
                    .HasColumnName("altura")
                    .IsRequired();

            //conf. propiedad grupo sanguineo: nombre y not null
            this.Property(unaFicha => unaFicha.grupoSanguineo)
                    .HasColumnName("grupoSanguineo")
                    .IsRequired();

            //conf. propiedad hipertension arterial: nombre y not null
            this.Property(unaFicha => unaFicha.hiperArterial)
                    .HasColumnName("hiperArterial")
                    .IsRequired();

            //conf. propiedad diabetes: nombre y not null
            this.Property(unaFicha => unaFicha.diabetes)
                    .HasColumnName("diabetes")
                    .IsRequired();

            //conf. propiedad afecCardVascular: nombre y not null
            this.Property(unaFicha => unaFicha.afecCardVascular)
                    .HasColumnName("afecCardioVascular")
                    .IsRequired();

            //conf. propiedad afecRespiratoria: nombre y not null
            this.Property(unaFicha => unaFicha.afecResp)
                    .HasColumnName("afecResp")
                    .IsRequired();

            //conf. propiedad fuma: nombre y not null
            this.Property(unaFicha => unaFicha.fuma)
                    .HasColumnName("fuma")
                    .IsRequired();

            //conf. propiedad alcohol: nombre y not null
            this.Property(unaFicha => unaFicha.alcohol)
                    .HasColumnName("alcohol")
                    .IsRequired();

            //relacion de uno a uno con socio
            this.HasRequired<SocioDTO>(unaFicha => unaFicha.socio)
                .WithMany(unSocio => unSocio.HistorialMedico)
                    .Map(pMap => pMap.MapKey("fichaMedica"));

            //relacion de uno a muchos con contacto de emergencia
            this.HasMany<ContactoEmergenciaDTO>(unaFicha => unaFicha.ContactoEmergencia)
                .WithOptional(unContacto => unContacto.fichaMedica)
                    .Map(pMap => pMap.MapKey("contactoEmergencia"));

            //relacion de uno a muchos con Medicacion
            this.HasMany<MedicacionDTO>(unMed => unMed.Medicaciones)
                .WithOptional(unContacto => unContacto.fichaMedica)
                    .Map(pMap => pMap.MapKey("medicacion"));

            //relacion de uno a muchos con Medicacion
            this.HasMany<EnfermedadDTO>(unaEnf => unaEnf.Enfermedades)
                .WithOptional(unContacto => unContacto.fichaMedica)
                    .Map(pMap => pMap.MapKey("medicacion"));

            //relacion de uno a muchos con Medicacion
            this.HasMany<ActividadFisicaDTO>(unaAct => unaAct.ActividadesFisicas)
                .WithOptional(unContacto => unContacto.fichaMedica)
                    .Map(pMap => pMap.MapKey("actividadFisica"));

            //relacion de uno a muchos con Medicacion
            this.HasMany<OperacionDTO>(unaOp => unaOp.Operaciones)
                .WithOptional(unContacto => unContacto.fichaMedica)
                    .Map(pMap => pMap.MapKey("operacion"));

            //relacion de uno a muchos con Medicacion
            this.HasMany<LimitacionFisicaDTO>(unaLim => unaLim.LimitacionesFisicas)
                .WithOptional(unContacto => unContacto.fichaMedica)
                    .Map(pMap => pMap.MapKey("limitacionFisica"));
        }
    }
}
