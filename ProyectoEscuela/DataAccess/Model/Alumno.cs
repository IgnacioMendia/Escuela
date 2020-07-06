using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [Display(Name = "Curso")]
        public int CursoId { get; set; }        
        public int Documento { get; set; }

        //NAVEGACION
        public Curso curso { get; set; }
    
    }
}
