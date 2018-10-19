using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using DomainLayer;

namespace DataLayer.Mapping
{
    class LimitacionFisicaMap : EntityTypeConfiguration<LimitacionFisica>
    {
        public LimitacionFisicaMap()
        {
            //nombre de la tabla en base de datos
            this.ToTable("LimitacionFisica");

            //conf. clave primaria: nombre, auto-increment y not null
            this.HasKey(unaLimitacion => unaLimitacion.Id)
                .Property(unaLimitacion => unaLimitacion.Id)
                    .HasColumnName("limitacionId")
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                    .IsRequired();

            //conf. propiedad nombre: nombre y not null
            this.Property(unaLimitacion => unaLimitacion.Nombre)
                    .HasColumnName("nombre")
                    .IsRequired();

            //conf. propiedad fecha ocurrencia: nombre y not null
            this.Property(unaLimitacion => unaLimitacion.FecOcurrencia)
                    .HasColumnName("fechaOperacion")
                    .IsOptional();

            //conf. propiedad fecha recuperacion: nombre y not null
            this.Property(unaLimitacion => unaLimitacion.FecRecuperacion)
                    .HasColumnName("fechaRecuperacion")
                    .IsOptional();
        }
    }
}
