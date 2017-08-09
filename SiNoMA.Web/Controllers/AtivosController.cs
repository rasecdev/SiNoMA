using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SiNoMA.Domain;
using SiNoMA.Infra.DataContexts;

namespace SiNoMA.Web.Controllers
{
    public class AtivosController : Controller
    {
        private SiNoMAContext db = new SiNoMAContext();

        // GET: Ativoes
        public ActionResult Index()
        {
            return View(db.Ativoes.ToList());
        }

        // GET: Ativoes/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ativo ativo = db.Ativoes.Find(id);
            if (ativo == null)
            {
                return HttpNotFound();
            }
            return View(ativo);
        }

        // GET: Ativoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ativoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nome,Descricao")] Ativo ativo)
        {
            if (ModelState.IsValid)
            {
                db.Ativoes.Add(ativo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ativo);
        }

        // GET: Ativoes/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ativo ativo = db.Ativoes.Find(id);
            if (ativo == null)
            {
                return HttpNotFound();
            }
            return View(ativo);
        }

        // POST: Ativoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nome,Descricao")] Ativo ativo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ativo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ativo);
        }

        // GET: Ativoes/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ativo ativo = db.Ativoes.Find(id);
            if (ativo == null)
            {
                return HttpNotFound();
            }
            return View(ativo);
        }

        // POST: Ativoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Ativo ativo = db.Ativoes.Find(id);
            db.Ativoes.Remove(ativo);
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
