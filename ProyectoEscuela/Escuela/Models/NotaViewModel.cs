using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Escuela.Models
{
    public class NotaViewModel
    {
        public int Id { get; set; }
        public double NotaPrimerTrimestre { get; set; }
        public double NotaSegundoTrimestre { get; set; }
        public double NotaTercerTrimestre { get; set; }
        public int NotaFinal { get; set; }
        public int AlumnoId { get; set; }
        public int MateriaId { get; set; }
        public AlumnoViewModel Alumno { get; set; }
        public MateriaViewModel Materia { get; set; }

        public NotaViewModel()
        {

        }
        //public NotaViewModel (Nota entity)
        //{
        //    this.Id = entity.Id;
        //    this.NotaPrimerTrimestre = entity.NotaPrimerTrimestre;
        //    this.NotaSegundoTrimestre = entity.NotaSegundoTrimestre;
        //    this.NotaTercerTrimestre = entity.NotaTercerTrimestre;
        //    this.NotaFinal =entity.NotaFinal;                     
        //    this.AlumnoId = entity.AlumnoId;
        //    this.MateriaId = entity.MateriaId;
        //}
        //public Nota ToEntity()
        //{
        //    return new Nota()
        //    {
        //        Id = this.Id,
        //        NotaPrimerTrimestre = this.NotaPrimerTrimestre,
        //        NotaSegundoTrimestre = this.NotaSegundoTrimestre,
        //        NotaTercerTrimestre = this.NotaTercerTrimestre,
        //        NotaFinal = this.NotaFinal,
        //        AlumnoId = this.AlumnoId,
        //        MateriaId = this.MateriaId
        //    };
        //}

    }
}