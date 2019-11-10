using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Colegio.Data;
using Colegio.Data.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Colegio.Services
{
    public class EstudianteController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EstudianteController(ApplicationDbContext dbContext)
        {
            _db = dbContext;
        }




        // GET: Estudiante
        public ActionResult Index()
        {


            Persona pe = new Persona();
            Estudiante es = new Estudiante();

            pe.Nombre = "Jose";
            pe.Apellidos = "Mendoza";

            es.Matricula = "123456";
            es.Persona = pe;

            _db.Estudiantes.Add(es);
            _db.SaveChanges();

            _db.Estudiantes.Remove(es);
            _db.SaveChanges();

            _db.Estudiantes.Update(es);
            _db.SaveChanges();

            return View();
        }

        // GET: Estudiante/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Estudiante/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estudiante/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Estudiante/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Estudiante/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Estudiante/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Estudiante/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}