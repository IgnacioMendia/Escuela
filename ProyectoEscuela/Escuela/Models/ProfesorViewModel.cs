using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Escuela.Models
{
    public class ProfesorViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Documento { get; set; }
        public int MateriaId { get; set; }
        public MateriaViewModel Materia { get; set; }
        public ProfesorViewModel()
        {

        }

        public ProfesorViewModel(Profesor entity)
        {
            this.Id = entity.Id;
            this.Nombre = entity.Nombre;
            this.Apellido = entity.Apellido;
            this.Documento = entity.Documento;
            this.MateriaId = entity.MateriaId;
        }
        public Profesor ToEntity()
        {
            return new Profesor()
            {
                Id = this.Id,
                Nombre = this.Nombre,
                Apellido = this.Apellido,
                Documento = this.Documento,
                MateriaId = this.MateriaId,
            };
        }
    }   
}