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
    public class TipoEnviosController : Controller
    {
        private SiNoMAContext db = new SiNoMAContext();

        // GET: TipoEnvios
        public ActionResult Index()
        {
            return View(db.TipoEnvios.ToList());
        }

        // GET: TipoEnvios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoEnvio tipoEnvio = db.TipoEnvios.Find(id);
            if (tipoEnvio == null)
            {
                return HttpNotFound();
            }
            return View(tipoEnvio);
        }

        // GET: TipoEnvios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoEnvios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nome,Descricao")] TipoEnvio tipoEnvio)
        {
            if (ModelState.IsValid)
            {
                db.TipoEnvios.Add(tipoEnvio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoEnvio);
        }

        // GET: TipoEnvios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoEnvio tipoEnvio = db.TipoEnvios.Find(id);
            if (tipoEnvio == null)
            {
                return HttpNotFound();
            }
            return View(tipoEnvio);
        }

        // POST: TipoEnvios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nome,Descricao")] TipoEnvio tipoEnvio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoEnvio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoEnvio);
        }

        // GET: TipoEnvios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoEnvio tipoEnvio = db.TipoEnvios.Find(id);
            if (tipoEnvio == null)
            {
                return HttpNotFound();
            }
            return View(tipoEnvio);
        }

        // POST: TipoEnvios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoEnvio tipoEnvio = db.TipoEnvios.Find(id);
            db.TipoEnvios.Remove(tipoEnvio);
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
