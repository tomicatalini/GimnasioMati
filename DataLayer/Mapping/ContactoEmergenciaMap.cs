using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using DomainLayer;

namespace DataLayer.Mapping
{
    class ContactoEmergenciaMap : EntityTypeConfiguration<ContactoEmergencia>
    {
        public ContactoEmergenciaMap()
        {
            //nombre de la tabla en base de datos
            this.ToTable("ContactoEmergencia");

            //conf. clave primaria: nombre, auto-increment y not null
            this.HasKey(unContacto => unContacto.Id)
                .Property(unContacto => unContacto.Id)
                    .HasColumnName("contactoId")
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                    .IsRequired();

            //conf. propiedad nombre: nombre y not null
            this.Property(unContacto => unContacto.Nombre)
                    .HasColumnName("nombre")
                    .IsRequired();

            //conf. propiedad telefono: nombre y not null
            this.Property(unContacto => unContacto.Telefono)
                    .HasColumnName("telefono")
                    .IsRequired();

        }
    }
}
