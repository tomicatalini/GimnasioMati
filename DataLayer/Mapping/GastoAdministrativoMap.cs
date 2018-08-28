using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Mapping
{
    class GastoAdministrativoMap : EntityTypeConfiguration<GastoAdministrativoDTO>
    {
        public GastoAdministrativoMap()
        {
            //nombre de la table en base de datos
            this.ToTable("GastoAdministrativo");

            //conf. de clave primaria: nombre, auto-increment y not null
            this.HasKey(unGasto => unGasto.Id)
                .Property(unGasto => unGasto.Id)
                    .HasColumnName("gastoId")
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                    .IsRequired();

            //conf. propiedad cantidad: nombre y not null
            this.Property(unGasto => unGasto.Cantidad)
                    .HasColumnName("cantidad")
                    .IsRequired();

            //conf. propiedad descripcion: nombre y not null
            this.Property(unGasto => unGasto.Descripcion)
                    .HasColumnName("descripcion")
                    .IsRequired();

            //conf. propiedad precioUnitario: nombre y not null
            this.Property(unGasto => unGasto.PrecioUnitario)
                    .HasColumnName("precioUnitario")
                    .IsRequired();

            //conf. propiedad fecha: nombre y not null
            this.Property(unGasto => unGasto.Fecha)
                    .HasColumnName("fecha")
                    .IsRequired();
        }
    }
}
