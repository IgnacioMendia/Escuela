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
    public class MateriaMapping: EntityTypeConfiguration<Materia>
    {
        public MateriaMapping()
        {
            HasKey(x => x.Id);
            Property(x => x.Nombre).HasColumnType("nvarchar").HasMaxLength(50).HasColumnName("Materia");
            Property(x=> x.Nombre).HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("IX_NombreUnico") { IsUnique = true }));
        }



    }
}
