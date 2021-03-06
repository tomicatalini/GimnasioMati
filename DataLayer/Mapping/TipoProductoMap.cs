﻿using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using DomainLayer;

namespace DataLayer.Mapping
{
    class TipoProductoMap : EntityTypeConfiguration<TipoProducto>
    {
        public TipoProductoMap()
        {
            //nombre de la tabla en base de datos
            this.ToTable("TipoProducto");

            //conf. clave primaria: nombre, auto-increment y not null
            this.HasKey(unTipo => unTipo.Id)
                .Property(unTipo => unTipo.Id)
                    .HasColumnName("tipoId")
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                    .IsRequired();

            //conf. propiedad nombre: nombre y not null
            this.Property(unTipo => unTipo.Nombre)
                    .HasColumnName("nombre")
                    .IsRequired();

            //relacion de muchos a uno con producto
            this.HasMany(unTipo => unTipo.Productos)
                .WithRequired(unProducto => unProducto.TipoProducto)
                    .HasForeignKey(unProducto => unProducto.TipoProductoId);
        }
    }
}
