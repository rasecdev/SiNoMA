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
    public class AndamentoNotificacoesController : Controller
    {
        private SiNoMAContext db = new SiNoMAContext();

        // GET: AndamentoNotificacoes
        public ActionResult Index()
        {
            return View(db.AndamentoNotificacaos.ToList());
        }

        // GET: AndamentoNotificacoes/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AndamentoNotificacao andamentoNotificacao = db.AndamentoNotificacaos.Find(id);
            if (andamentoNotificacao == null)
            {
                return HttpNotFound();
            }
            return View(andamentoNotificacao);
        }

        // GET: AndamentoNotificacoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AndamentoNotificacoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Descricao,DataHora")] AndamentoNotificacao andamentoNotificacao)
        {
            if (ModelState.IsValid)
            {
                db.AndamentoNotificacaos.Add(andamentoNotificacao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(andamentoNotificacao);
        }

        // GET: AndamentoNotificacoes/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AndamentoNotificacao andamentoNotificacao = db.AndamentoNotificacaos.Find(id);
            if (andamentoNotificacao == null)
            {
                return HttpNotFound();
            }
            return View(andamentoNotificacao);
        }

        // POST: AndamentoNotificacoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Descricao,DataHora")] AndamentoNotificacao andamentoNotificacao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(andamentoNotificacao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(andamentoNotificacao);
        }

        // GET: AndamentoNotificacoes/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AndamentoNotificacao andamentoNotificacao = db.AndamentoNotificacaos.Find(id);
            if (andamentoNotificacao == null)
            {
                return HttpNotFound();
            }
            return View(andamentoNotificacao);
        }

        // POST: AndamentoNotificacoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            AndamentoNotificacao andamentoNotificacao = db.AndamentoNotificacaos.Find(id);
            db.AndamentoNotificacaos.Remove(andamentoNotificacao);
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
