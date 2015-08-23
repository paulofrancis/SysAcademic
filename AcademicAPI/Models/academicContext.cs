using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using AcademicAPI.Models.Mapping;

namespace AcademicAPI.Models
{
    public partial class academicContext : DbContext
    {
        static academicContext()
        {
            Database.SetInitializer<academicContext>(null);
        }

        public academicContext()
            : base("Name=academicContext")
        {
        }

        public DbSet<curso> cursos { get; set; }
        public DbSet<disciplina> disciplinas { get; set; }
        public DbSet<nota> notas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new cursoMap());
            modelBuilder.Configurations.Add(new disciplinaMap());
            modelBuilder.Configurations.Add(new notaMap());
        }
    }
}
