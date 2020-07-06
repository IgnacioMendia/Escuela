using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Escuela.Models
{
    public class CursoViewModel
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public CursoViewModel()
        {

        }

        public CursoViewModel(Curso entity)
        {
            this.Id = entity.Id;
            this.Descripcion = entity.Descripcion;
        }
        public Curso ToEntity()
        {
            return new Curso()
            {
                Id=this.Id,
                Descripcion = this.Descripcion
            };
        }



    }
}