using System.Data.Entity.ModelConfiguration; 

namespace DataLayer.Mapping
{
    class PagoMap : EntityTypeConfiguration<PagoDTO>
    {
        public PagoMap()
        {
            //Nombre de la tabla en base de datos
            this.ToTable("Pago");

            //conf. clave primaria: nombre, auto increment y not null
            this.HasKey(unPago => unPago.nroPago)
                .Property(unPago => unPago.nroPago)
                    .HasColumnName("nroPago")
                    .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                    .IsRequired();

            //conf. propiedad fechaPago: nombre y not null
            this.Property(unPago => unPago.fechaPago)
                    .HasColumnName("fechaPago")
                    .IsRequired();

            //conf. propiedad importe: nombre y not null
            this.Property(unPago => unPago.importe)
                    .HasColumnName("importe")
                    .IsRequired();

            //relacion de uno a uno con cuota
            this.HasRequired<CuotaDTO>(unPago => unPago.Cuota)
                .WithMany(unaCuota => unaCuota.Pagos)
                .Map(pMap => pMap.MapKey("cuota"));
        }
    }
}
