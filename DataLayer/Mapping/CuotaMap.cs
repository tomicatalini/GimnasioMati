using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Mapping
{
    class CuotaMap : EntityTypeConfiguration<CuotaDTO>
    {
        public CuotaMap()
        {
            //Nombre de la tabla en base de datos
            this.ToTable("Cuota");

            //Conf. clave primaria: nombre, auto increment y not null
            this.HasKey<int>(unaCuota => unaCuota.NroCuota)
                .Property(unaCuota => unaCuota.NroCuota)
                    .HasColumnName("nroCouta")
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                    .IsRequired();

            //Conf. propiedad fechaEmision: nombre y not null
            this.Property(unaCuota => unaCuota.FechaEmision)
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

            //relacion uno a uno entre con socio.
            this.HasRequired<SocioDTO>(unaCuota => unaCuota.Socio)
                .WithMany(unSocio => unSocio.Cuotas)
                .Map(pMap => pMap.MapKey("socio"));

            //relacion de uno a muchos entre cuota y pago
            this.HasMany<PagoDTO>(unaCuota => unaCuota.Pagos)
                .WithRequired(unPago => unPago.Cuota)
                    .Map(pMap => pMap.MapKey("nroPago"));



        }
    }
}
