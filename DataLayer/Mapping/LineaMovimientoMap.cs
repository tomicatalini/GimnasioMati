using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataLayer.Mapping
{
    class LineaMovimientoMap : EntityTypeConfiguration<LineaMovimientoDTO>
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

            //relacion de uno a muchos con movimiento
            this.HasRequired(unaLinea => unaLinea.Movimiento)
                .WithMany(unMovimiento => unMovimiento.LineaMovimientos)
                    .Map(pMap => pMap.MapKey("lineaMovimiento"));

            //relacion de uno a mucho con producto
            this.HasRequired(unaLinea => unaLinea.Producto)
                .WithMany(unProducto => unProducto.LineaMovimientos)
                    .Map(pMap => pMap.MapKey("lineaMovimiento"));
        }
    }
}
