using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Mapping
{
    class ProductoMap : EntityTypeConfiguration<ProductoDTO>
    {
        public ProductoMap()
        {
            //nombre de la tabla en base de datos
            this.ToTable("Producto");

            //conf. clave primaria: nombre, auto-increment y not null
            this.HasKey(unProducto => unProducto.CodProducto)
                .Property(unMovimiento => unMovimiento.CodProducto)
                    .HasColumnName("codProducto")
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                    .IsRequired();

            //conf. propiedad nombre: nombre y not null
            this.Property(unProducto => unProducto.Nombre)
                    .HasColumnName("nombre")
                    .IsRequired();

            //conf. propiedad precio: nombre y not null
            this.Property(unProducto => unProducto.Precio)
                    .HasColumnName("precio")
                    .IsRequired();

            //conf. propiedad descripcion: nombre y not null
            this.Property(unProducto => unProducto.Descripcion)
                    .HasColumnName("descripcion")
                    .IsRequired();

            //conf. propiedad stock: nombre y not null
            this.Property(unProducto => unProducto.Stock)
                    .HasColumnName("stock")
                    .IsRequired();

            //conf. propiedad activo: nombre y not null
            this.Property(unProducto => unProducto.Activo)
                    .HasColumnName("activo")
                    .IsRequired();

            //relacion de uno a muchos con tipo de producto
            this.HasRequired(unProducto => unProducto.TipoProducto)
                .WithMany(unTipo => unTipo.Productos)
                    .Map(pMap => pMap.MapKey("tipo"));

            //relacion de muchos a uno con linea de movimiento
            this.HasMany(unProducto => unProducto.LineaMovimientos)
                .WithRequired(unaLinea => unaLinea.Producto)
                    .Map(pMap => pMap.MapKey("movimiento"));
        }
    }
}
