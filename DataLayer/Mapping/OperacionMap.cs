using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using DomainLayer;

namespace DataLayer.Mapping
{
    class OperacionMap : EntityTypeConfiguration<Operacion>
    {
        public OperacionMap()
        {
            //nombre de la tabla en base de datos
            this.ToTable("Operacion");

            //conf. clave primaria: nombre, auto-increment y not null
            this.HasKey(unaOperacion => unaOperacion.Id)
                .Property(unaOperacion => unaOperacion.Id)
                    .HasColumnName("operacionId")
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                    .IsRequired();

            //conf. propiedad nombre: nombre y not null
            this.Property(unaOperacion => unaOperacion.Nombre)
                    .HasColumnName("nombre")
                    .IsRequired();

            //conf. propiedad fecha operacion: nombre y not null
            this.Property(unaOperacion => unaOperacion.FecOperacion)
                    .HasColumnName("fechaOperacion")
                    .IsOptional();

            //conf. propiedad fecha recperacion: nombre y not null
            this.Property(unaOperacion => unaOperacion.FecAltaMedica)
                    .HasColumnName("fechaRecuperacion")
                    .IsOptional();
        }
    }
}
