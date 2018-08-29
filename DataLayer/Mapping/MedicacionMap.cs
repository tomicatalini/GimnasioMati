using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Mapping
{
    class MedicacionMap : EntityTypeConfiguration<MedicacionDTO>
    {
        public MedicacionMap()
        {
            //nombre de la tabla en base de datos
            this.ToTable("Medicamento");

            //conf. clave primaria: nombre, auto-increment y not null
            this.HasKey(unMedicamento => unMedicamento.Id)
                .Property(unContacto => unContacto.Id)
                    .HasColumnName("medicamentoId")
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                    .IsRequired();

            //conf. propiedad nombre: nombre y not null
            this.Property(unMedicamento => unMedicamento.Nombre)
                    .HasColumnName("nombre")
                    .IsRequired();
        }
    }
}