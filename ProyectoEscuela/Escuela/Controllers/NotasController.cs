﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DataAccess;
using DataAccess.Model;

namespace Escuela.Controllers
{
    public class NotasController : Controller
    {
        private Context db = new Context();

        // GET: Notas
        public ActionResult Index()
        {
            var nota = db.Nota.Include(n => n.alumno).Include(n => n.materia);
            return View(nota.ToList());
        }

        // GET: Notas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nota nota = db.Nota.Find(id);
            if (nota == null)
            {
                return HttpNotFound();
            }
            return View(nota);
        }

        // GET: Notas/Create
        public ActionResult Create()
        {
            ViewBag.AlumnoId = new SelectList(db.Alumno, "Id", "Nombre");
            ViewBag.MateriaId = new SelectList(db.Materia, "Id", "Nombre");
            return View();
        }

        // POST: Notas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NotaPrimerTrimestre,NotaSegundoTrimestre,NotaTercerTrimestre,NotaFinal,AlumnoId,MateriaId")] Nota nota)
        {
            if (ModelState.IsValid)
            {
                db.Nota.Add(nota);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AlumnoId = new SelectList(db.Alumno, "Id", "Nombre", nota.AlumnoId);
            ViewBag.MateriaId = new SelectList(db.Materia, "Id", "Nombre", nota.MateriaId);
            return View(nota);
        }

        // GET: Notas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nota nota = db.Nota.Find(id);
            if (nota == null)
            {
                return HttpNotFound();
            }
            ViewBag.AlumnoId = new SelectList(db.Alumno, "Id", "Nombre", nota.AlumnoId);
            ViewBag.MateriaId = new SelectList(db.Materia, "Id", "Nombre", nota.MateriaId);
            return View(nota);
        }

        // POST: Notas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NotaPrimerTrimestre,NotaSegundoTrimestre,NotaTercerTrimestre,NotaFinal,AlumnoId,MateriaId")] Nota nota)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nota).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AlumnoId = new SelectList(db.Alumno, "Id", "Nombre", nota.AlumnoId);
            ViewBag.MateriaId = new SelectList(db.Materia, "Id", "Nombre", nota.MateriaId);
            return View(nota);
        }

        // GET: Notas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nota nota = db.Nota.Find(id);
            if (nota == null)
            {
                return HttpNotFound();
            }
            return View(nota);
        }

        // POST: Notas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Nota nota = db.Nota.Find(id);
            db.Nota.Remove(nota);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
