using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2020RC605_PRACTICA0402;

namespace _2020RC605_PRACTICA0402.Controllers
{
    public class TallasController : Controller
    {
        private PRODUCTOSEntities db = new PRODUCTOSEntities();

        // GET: Tallas
        public ActionResult Index()
        {
            return View(db.Tallas.ToList());
        }

        // GET: Tallas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tallas tallas = db.Tallas.Find(id);
            if (tallas == null)
            {
                return HttpNotFound();
            }
            return View(tallas);
        }

        // GET: Tallas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tallas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,talla,estado")] Tallas tallas)
        {
            if (ModelState.IsValid)
            {
                db.Tallas.Add(tallas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tallas);
        }

        // GET: Tallas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tallas tallas = db.Tallas.Find(id);
            if (tallas == null)
            {
                return HttpNotFound();
            }
            return View(tallas);
        }

        // POST: Tallas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,talla,estado")] Tallas tallas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tallas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tallas);
        }

        // GET: Tallas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tallas tallas = db.Tallas.Find(id);
            if (tallas == null)
            {
                return HttpNotFound();
            }
            return View(tallas);
        }

        // POST: Tallas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tallas tallas = db.Tallas.Find(id);
            db.Tallas.Remove(tallas);
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
