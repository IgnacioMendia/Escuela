using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Materia
    {
        public int Id { get; set; }
        [Display(Name ="Materia")]
        public string Nombre { get; set; }
    }
}
