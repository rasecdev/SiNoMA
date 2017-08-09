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
    public class NotificacoesController : Controller
    {
        private SiNoMAContext db = new SiNoMAContext();

        // GET: Notificacoes
        public ActionResult Index()
        {
            return View(db.Notificacaos.ToList());
        }

        // GET: Notificacoes/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notificacao notificacao = db.Notificacaos.Find(id);
            if (notificacao == null)
            {
                return HttpNotFound();
            }
            return View(notificacao);
        }

        // GET: Notificacoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Notificacoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nome,DataParaEnvio,Repeticao,Mensagem,NotificacaoAtiva")] Notificacao notificacao)
        {
            if (ModelState.IsValid)
            {
                db.Notificacaos.Add(notificacao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(notificacao);
        }

        // GET: Notificacoes/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notificacao notificacao = db.Notificacaos.Find(id);
            if (notificacao == null)
            {
                return HttpNotFound();
            }
            return View(notificacao);
        }

        // POST: Notificacoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nome,DataParaEnvio,Repeticao,Mensagem,NotificacaoAtiva")] Notificacao notificacao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(notificacao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(notificacao);
        }

        // GET: Notificacoes/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notificacao notificacao = db.Notificacaos.Find(id);
            if (notificacao == null)
            {
                return HttpNotFound();
            }
            return View(notificacao);
        }

        // POST: Notificacoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Notificacao notificacao = db.Notificacaos.Find(id);
            db.Notificacaos.Remove(notificacao);
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
