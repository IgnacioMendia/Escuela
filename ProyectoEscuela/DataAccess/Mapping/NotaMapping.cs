using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class NotaMapping : EntityTypeConfiguration<Nota>
    {
        public NotaMapping()
        {
            HasKey(x => x.Id);
            Property(x => x.MateriaId).IsRequired();
            Property(x => x.AlumnoId).IsRequired();
        }
    }
}
