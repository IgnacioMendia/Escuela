using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Nota
    {
        public int Id { get; set; }
        [Display(Name = "Primer trimestre")]
        public double ? NotaPrimerTrimestre { get; set; }
        [Display(Name = "Segundo trimestre")]
        public double ? NotaSegundoTrimestre { get; set; }
        [Display(Name = "Tercer trimestre")]
        public double ? NotaTercerTrimestre { get; set; }
        [Display(Name = "Nota final")]
        public int? NotaFinal { get; set; }
        [Display(Name="Alumno")]
        public int AlumnoId { get; set; }

        [Display(Name = "Materia")]
        public int MateriaId { get; set; }

        //NAVEGACION
        public Alumno alumno { get; set; }
        public Materia materia { get; set; }
    }
}
