using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Escuela.Models
{
    public class AlumnoViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio.")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio.")]
        public int CursoId { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio.")]
        public int Documento { get; set; }
        public CursoViewModel Curso { get; set; }


        public AlumnoViewModel()
        {

        }

        public AlumnoViewModel(Alumno entity)
        {
            this.Id = entity.Id;
            this.Nombre = entity.Nombre;
            this.Apellido = entity.Apellido;
            this.CursoId = entity.CursoId;
            this.Documento = entity.Documento;
        }

        public Alumno toentity()
        {
            return new Alumno()
            {
                Id = this.Id,
                Nombre = this.Nombre,
                Apellido= this.Apellido,
                CursoId = this.CursoId,
                Documento = this.Documento
            };   
        }
    }
}