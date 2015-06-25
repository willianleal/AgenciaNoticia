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
    public class SecoesController : Controller
    {
        private AgenciaNoticiaContext db = new AgenciaNoticiaContext();

        // GET: Secoes
        public ActionResult Index()
        {
            return View(db.Secaos.ToList());
        }

        // GET: Secoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Secao secao = db.Secaos.Find(id);
            if (secao == null)
            {
                return HttpNotFound();
            }
            return View(secao);
        }

        // GET: Secoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Secoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "codSecao,secao,codPessoa_Gerente,dataCadastro")] Secao secao)
        {
            if (ModelState.IsValid)
            {
                db.Secaos.Add(secao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(secao);
        }

        // GET: Secoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Secao secao = db.Secaos.Find(id);
            if (secao == null)
            {
                return HttpNotFound();
            }
            return View(secao);
        }

        // POST: Secoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "codSecao,secao,codPessoa_Gerente,dataCadastro")] Secao secao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(secao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(secao);
        }

        // GET: Secoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Secao secao = db.Secaos.Find(id);
            if (secao == null)
            {
                return HttpNotFound();
            }
            return View(secao);
        }

        // POST: Secoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Secao secao = db.Secaos.Find(id);
            db.Secaos.Remove(secao);
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
