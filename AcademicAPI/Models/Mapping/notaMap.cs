using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AcademicAPI.Models.Mapping
{
    public class notaMap : EntityTypeConfiguration<nota>
    {
        public notaMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.disciplina)
                .IsRequired()
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("nota");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.disciplina).HasColumnName("disciplina");
            this.Property(t => t.valor).HasColumnName("valor");
            this.Property(t => t.data).HasColumnName("data");
        }
    }
}
