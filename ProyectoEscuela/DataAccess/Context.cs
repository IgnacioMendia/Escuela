using DataAccess.Mapping;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Context:DbContext
    {
        public Context(): base(ConfigurationManager.ConnectionStrings["Escuela"].ConnectionString)
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new AlumnoMapping());
            modelBuilder.Configurations.Add(new MateriaMapping());
            modelBuilder.Configurations.Add(new NotaMapping());
            modelBuilder.Configurations.Add(new ProfesorMapping());
            modelBuilder.Configurations.Add(new CursoMapping());
        }
        public DbSet<Alumno> Alumno { get; set; }
        public DbSet<Materia> Materia { get; set; }
        public DbSet<Nota> Nota { get; set; }
        public DbSet<Profesor> Profesor { get; set; }
        public DbSet<Curso> Curso { get; set; }
    }
}
