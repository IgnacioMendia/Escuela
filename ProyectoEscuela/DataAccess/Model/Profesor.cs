using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Profesor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Documento { get; set; }
        [Display(Name = "Materia a dictar")]
        public int MateriaId { get; set; }

        //NAVEGACION
        public Materia materia { get; set; }
    }
}
