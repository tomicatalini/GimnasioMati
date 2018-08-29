﻿using System.Data.Entity.ModelConfiguration; 

namespace DataLayer.Mapping
{
    class PagoMap : EntityTypeConfiguration<PagoDTO>
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
            this.Property(unPago => unPago.FechaPago)
                    .HasColumnName("fechaPago")
                    .IsRequired();

            //conf. propiedad importe: nombre y not null
            this.Property(unPago => unPago.Importe)
                    .HasColumnName("importe")
                    .IsRequired();
        }
    }
}
