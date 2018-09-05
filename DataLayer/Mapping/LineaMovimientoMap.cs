using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DomainLayer;

namespace DataLayer.Mapping
{
    class LineaMovimientoMap : EntityTypeConfiguration<LineaMovimiento>
    {
        public LineaMovimientoMap()
        {
            //nombre de la tabla en base de datos
            this.ToTable("LineaMovimiento");

            //conf. clave primaria:: nombre, auto-increment y not null
            this.HasKey(unaLinea => unaLinea.Id)
                .Property(unalinea => unalinea.Id)
                    .HasColumnName("nroLinea")
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                    .IsRequired();

            //conf. propiedad precio unitario: nombre y not null
            this.Property(unaLinea => unaLinea.PrecioUnitario)
                    .HasColumnName("precioUnitario")
                    .IsRequired();

            //conf. propiedad cantidad: nombre y not null
            this.Property(unaLinea => unaLinea.Cantidad)
                    .HasColumnName("cantidad")
                    .IsRequired();
        }
    }
}
