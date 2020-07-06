using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Curso
    {
        public int Id { get; set; }
        [Display(Name = "Curso")]
        public string Descripcion { get; set; }
    }
}
