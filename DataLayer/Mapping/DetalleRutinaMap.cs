﻿using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using DomainLayer;

namespace DataLayer.Mapping
{
    class DetalleRutinaMap : EntityTypeConfiguration<DetalleRutina>
    {
        public DetalleRutinaMap()
        {
            //Nombre de tabla en base de datos
            this.ToTable("DetalleRutina");

            //conf. clave primaria: nombre, autoincrement y not null
            this.HasKey(unDetalle => unDetalle.Id)
                .Property(unDetalle => unDetalle.Id)
                    .HasColumnName("detalleId")
                    .IsRequired();

            //conf. propiedad dia: nombre y not null
            this.Property(unDetalle => unDetalle.Dia)
                    .HasColumnName("dia")
                    .IsRequired();

            //conf. propiedad descanso: nombre y not null
            this.Property(unDetalle => unDetalle.Descanso)
                    .HasColumnName("descanso")
                    .IsRequired();

            //conf. propiedad dia: nombre y not null
            this.Property(unDetalle => unDetalle.SeriesxRepeticiones)
                    .HasColumnName("seriexRepeticion")
                    .IsRequired();
        }
    }
}
