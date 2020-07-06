using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Escuela.Models
{
    public class MateriaViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public MateriaViewModel()
        {

        }

        public MateriaViewModel(Materia entity)
        {
            this.Id = entity.Id;
            this.Nombre = entity.Nombre;
        }

        public Materia ToEntity()
        {
            return new Materia()
            {
                Id = this.Id,
                Nombre = this.Nombre
            };
        }
    }
}