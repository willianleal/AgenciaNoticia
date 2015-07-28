using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AgenciaNoticia.Models;
using AgenciaNoticias.Models;

namespace AgenciaNoticia.Controllers
{
    public class MateriasController : Controller
    {
        private AgenciaNoticiaContext db = new AgenciaNoticiaContext();

        // GET: Materias
        public ActionResult Index()
        {
            var materias = db.Materias.Include(m => m.Jornalista).Include(m => m.Publicador).Include(m => m.Revisor).Include(m => m.Secao);
            return View(materias.ToList());
        }

        // GET: Materias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Materia materia = db.Materias.Find(id);
            if (materia == null)
            {
                return HttpNotFound();
            }
            return View(materia);
        }

        // GET: Materias/Create
        public ActionResult Create()
        {
            ViewBag.codPessoa_Jornalista = new SelectList(db.Pessoas, "codPessoa", "nome");
            ViewBag.codPessoa_Publicador = new SelectList(db.Pessoas, "codPessoa", "nome");
            ViewBag.codPessoa_Revisor = new SelectList(db.Pessoas, "codPessoa", "nome");
            ViewBag.codSecao = new SelectList(db.Secaos, "codSecao", "nome");
            return View();
        }

        // POST: Materias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "codMateria,codPessoa_Jornalista,codPessoa_Revisor,codPessoa_Publicador,nome,materiaEscrita,codSecao,status,dataCadastro,dataAtualizacao")] Materia materia)
        {
            if (ModelState.IsValid)
            {
                db.Materias.Add(materia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.codPessoa_Jornalista = new SelectList(db.Pessoas, "codPessoa", "nome", materia.codPessoa_Jornalista);
            ViewBag.codPessoa_Publicador = new SelectList(db.Pessoas, "codPessoa", "nome", materia.codPessoa_Publicador);
            ViewBag.codPessoa_Revisor = new SelectList(db.Pessoas, "codPessoa", "nome", materia.codPessoa_Revisor);
            ViewBag.codSecao = new SelectList(db.Secaos, "codSecao", "nome", materia.codSecao);
            return View(materia);
        }

        // GET: Materias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Materia materia = db.Materias.Find(id);
            if (materia == null)
            {
                return HttpNotFound();
            }
            ViewBag.codPessoa_Jornalista = new SelectList(db.Pessoas, "codPessoa", "nome", materia.codPessoa_Jornalista);
            ViewBag.codPessoa_Publicador = new SelectList(db.Pessoas, "codPessoa", "nome", materia.codPessoa_Publicador);
            ViewBag.codPessoa_Revisor = new SelectList(db.Pessoas, "codPessoa", "nome", materia.codPessoa_Revisor);
            ViewBag.codSecao = new SelectList(db.Secaos, "codSecao", "nome", materia.codSecao);
            return View(materia);
        }

        // POST: Materias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "codMateria,codPessoa_Jornalista,codPessoa_Revisor,codPessoa_Publicador,nome,materiaEscrita,codSecao,status,dataCadastro,dataAtualizacao")] Materia materia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(materia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.codPessoa_Jornalista = new SelectList(db.Pessoas, "codPessoa", "nome", materia.codPessoa_Jornalista);
            ViewBag.codPessoa_Publicador = new SelectList(db.Pessoas, "codPessoa", "nome", materia.codPessoa_Publicador);
            ViewBag.codPessoa_Revisor = new SelectList(db.Pessoas, "codPessoa", "nome", materia.codPessoa_Revisor);
            ViewBag.codSecao = new SelectList(db.Secaos, "codSecao", "nome", materia.codSecao);
            return View(materia);
        }

        // GET: Materias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Materia materia = db.Materias.Find(id);
            if (materia == null)
            {
                return HttpNotFound();
            }
            return View(materia);
        }

        // POST: Materias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Materia materia = db.Materias.Find(id);
            db.Materias.Remove(materia);
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
