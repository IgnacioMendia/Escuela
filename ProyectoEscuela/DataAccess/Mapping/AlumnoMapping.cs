using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class AlumnoMapping: EntityTypeConfiguration<Alumno>
    {
        public AlumnoMapping()
        {
            ToTable("Alumno");
            HasKey(x => x.Id);
            Property(x => x.Nombre).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Apellido).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.CursoId).IsRequired().HasColumnType("int");
            Property(x => x.Documento).HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("IX_DocumentoUnico") { IsUnique = true }));
        }
    }
}
