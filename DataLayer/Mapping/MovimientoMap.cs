using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using DomainLayer;

namespace DataLayer.Mapping
{
    class MovimientoMap : EntityTypeConfiguration<Movimiento>
    {
        public MovimientoMap()
        {
            //nombre de la tabla en base de datos
            this.ToTable("Movimiento");

            //conf. clave primaria: nombre, auto-increment y not null
            this.HasKey(unMovimiento => unMovimiento.Id)
                .Property(unMovimiento => unMovimiento.Id)
                    .HasColumnName("nroMovimiento")
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                    .IsRequired();

            //conf. propiedad tipo de movimiento: nombre y not null
            this.Property(unMovimiento => unMovimiento.TipoMovimiento)
                    .HasColumnName("tipo")
                    .IsRequired();

            //conf. propiedad fecha: nombre y not null
            this.Property(unMovimiento => unMovimiento.Fecha)
                    .HasColumnName("fecha")
                    .IsRequired();

            //relacion de muchos a uno con linea de movimiento
            this.HasMany(unMovimiento => unMovimiento.LineaMovimientos)
                .WithRequired(unaLinea => unaLinea.Movimiento)
                    .HasForeignKey(unaLinea => unaLinea.MovimientoId);
    }
    }
}
