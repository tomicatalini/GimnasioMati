using System.Data.Entity.ModelConfiguration;
using DomainLayer;

namespace DataLayer.Mapping
{
    class PagoMap : EntityTypeConfiguration<Pago>
    {
        public PagoMap()
        {
            //Nombre de la tabla en base de datos
            this.ToTable("Pago");

            //conf. clave primaria: nombre, auto increment y not null
            this.HasKey(unPago => unPago.NroPago)
                .Property(unPago => unPago.NroPago)
                    .HasColumnName("pagoId")
                    .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                    .IsRequired();

            //conf. propiedad fechaPago: nombre y not null
            this.Property(unPago => unPago.FecPago)
                    .HasColumnName("fechaPago")
                    .IsRequired();

            //conf. propiedad importe: nombre y not null
            this.Property(unPago => unPago.Importe)
                    .HasColumnName("importe")
                    .IsRequired();
        }
    }
}
