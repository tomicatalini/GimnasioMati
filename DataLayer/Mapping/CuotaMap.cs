using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using DomainLayer;

namespace DataLayer.Mapping
{
    class CuotaMap : EntityTypeConfiguration<Cuota>
    {
        public CuotaMap()
        {
            //Nombre de la tabla en base de datos
            this.ToTable("Cuota");

            //Conf. clave primaria: nombre, auto increment y not null
            this.HasKey<long>(unaCuota => unaCuota.NroCuota)
                .Property(unaCuota => unaCuota.NroCuota)
                    .HasColumnName("nroCouta")
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                    .IsRequired();

            //Conf. propiedad fechaEmision: nombre y not null
            this.Property(unaCuota => unaCuota.FecEmision)
                    .HasColumnName("fechaEmision")
                    .IsRequired();

            //Conf. propiedad descripcion: nombre y not null
            this.Property(unaCuota => unaCuota.Descripcion)
                    .HasColumnName("descripcion")
                    .IsRequired();

            //conf. propiedad monto: nombre y not null
            this.Property(unaCuota => unaCuota.Monto)
                    .HasColumnName("monto")
                    .IsRequired();

            //conf. propiedad mes: nombre y not null
            this.Property(unaCuota => unaCuota.Mes)
                    .HasColumnName("mesPeriodo")
                    .IsRequired();

            //conf. propiedad año: nombre y not null
            this.Property(unaCuota => unaCuota.Año)
                    .HasColumnName("añoPeriodo")
                    .IsRequired();

            //conf. propiedad pagada: nombre y not null
            this.Property(unaCuota => unaCuota.Pagada)
                    .HasColumnName("pagada")
                    .IsRequired();

            //relacion de uno a muchos con pago
            this.HasMany<Pago>(unaCuota => unaCuota.Pagos)
                .WithRequired(unPago => unPago.Cuota)
                    .HasForeignKey(unPago => unPago.NroCuota);



        }
    }
}
