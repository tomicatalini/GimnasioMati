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
            this.HasKey<int>(unaFicha => unaFicha.FichaId)
                .Property(unaFicha => unaFicha.FichaId)
                    .HasColumnName("fichaId")
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                    .IsRequired();
            
            //conf. propiedad fechaEntrega: nombre y not null
            this.Property(unaFicha => unaFicha.FechaEntrega)
                    .HasColumnName("fechaEntrega")
                    .IsRequired();

            //conf. propiedad peso: nombre y not null
            this.Property(unaFicha => unaFicha.Peso)
                    .HasColumnName("peso")
                    .IsRequired();

            //conf. propiedad altura: nombre y not null
            this.Property(unaFicha => unaFicha.Altura)
                    .HasColumnName("altura")
                    .IsRequired();

            //conf. propiedad grupo sanguineo: nombre y not null
            this.Property(unaFicha => unaFicha.GrupoSanguineo)
                    .HasColumnName("grupoSanguineo")
                    .IsRequired();

            //conf. propiedad hipertension arterial: nombre y not null
            this.Property(unaFicha => unaFicha.HiperArterial)
                    .HasColumnName("hiperArterial")
                    .IsRequired();

            //conf. propiedad diabetes: nombre y not null
            this.Property(unaFicha => unaFicha.Diabetes)
                    .HasColumnName("diabetes")
                    .IsRequired();

            //conf. propiedad afecCardVascular: nombre y not null
            this.Property(unaFicha => unaFicha.AfecCardVascular)
                    .HasColumnName("afecCardioVascular")
                    .IsRequired();

            //conf. propiedad afecRespiratoria: nombre y not null
            this.Property(unaFicha => unaFicha.AfecResp)
                    .HasColumnName("afecResp")
                    .IsRequired();

            //conf. propiedad fuma: nombre y not null
            this.Property(unaFicha => unaFicha.Fuma)
                    .HasColumnName("fuma")
                    .IsRequired();

            //conf. propiedad alcohol: nombre y not null
            this.Property(unaFicha => unaFicha.Alcohol)
                    .HasColumnName("alcohol")
                    .IsRequired();

            //relacion de uno a muchos con contacto de emergencia
            this.HasMany<ContactoEmergenciaDTO>(unaFicha => unaFicha.ContactoEmergencia)
                .WithRequired(unContacto => unContacto.FichaMedica)
                    .HasForeignKey(unContacto => unContacto.FichaId);

            //relacion de uno a muchos con Medicacion
            this.HasMany<MedicacionDTO>(unaFicha => unaFicha.Medicaciones)
                .WithRequired(unMedicamento => unMedicamento.FichaMedica)
                    .HasForeignKey(unMedicamento => unMedicamento.FichaId);

            //relacion de uno a muchos con nfermedad
            this.HasMany<EnfermedadDTO>(unaFicha => unaFicha.Enfermedades)
                .WithRequired(unaEnfermedad => unaEnfermedad.FichaMedica)
                    .HasForeignKey(unaEnfermedad => unaEnfermedad.FichaId);

            //relacion de uno a muchos con actividad fisica
            this.HasMany<ActividadFisicaDTO>(unaFicha => unaFicha.ActividadesFisicas)
                .WithRequired(unaActividad => unaActividad.FichaMedica)
                    .HasForeignKey(unaActividad => unaActividad.FichaId);

            //relacion de uno a muchos con operacion
            this.HasMany<OperacionDTO>(unaFicha => unaFicha.Operaciones)
                .WithRequired(unaOperacion => unaOperacion.FichaMedica)
                    .HasForeignKey(unaOperacion => unaOperacion.FichaId);

            //relacion de uno a muchos con limitacion fisica
            this.HasMany<LimitacionFisicaDTO>(unaFicha => unaFicha.LimitacionesFisicas)
                .WithRequired(unaLimitacion => unaLimitacion.FichaMedica)
                    .HasForeignKey(unaLimitacion => unaLimitacion.FichaId);
        }
    }
}
