using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AcademicAPI.Models.Mapping
{
    public class cursoMap : EntityTypeConfiguration<curso>
    {
        public cursoMap()
        {
            // Primary Key
            this.HasKey(t => t.sigla);

            // Properties
            this.Property(t => t.sigla)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.nome)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("curso");
            this.Property(t => t.sigla).HasColumnName("sigla");
            this.Property(t => t.nome).HasColumnName("nome");
        }
    }
}
