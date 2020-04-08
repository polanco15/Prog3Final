using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Programacion3.Models;

namespace Programacion3.Controllers
{
    public class EntradaMercanciasController : Controller
    {
        private FinalContext db = new FinalContext();

        // GET: EntradaMercancias
        public ActionResult Index()
        {
            var entradaMercancias = db.EntradaMercancias.Include(e => e.Producto).Include(e => e.Proveedor);
            return View(entradaMercancias.ToList());
        }

        // GET: EntradaMercancias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntradaMercancia entradaMercancia = db.EntradaMercancias.Find(id);
            if (entradaMercancia == null)
            {
                return HttpNotFound();
            }
            return View(entradaMercancia);
        }

        // GET: EntradaMercancias/Create
        public ActionResult Create()
        {
            ViewBag.IdProducto = new SelectList(db.Productos, "IdProducto", "Nombre");
            ViewBag.IdProveedor = new SelectList(db.Proveedors, "IdProveedor", "Nombre");
            return View();
        }

        // POST: EntradaMercancias/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdEntrada,IdProducto,IdProveedor,FechaEntrada,Cantidad")] EntradaMercancia entradaMercancia)
        {
            if (ModelState.IsValid)
            {
                db.EntradaMercancias.Add(entradaMercancia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdProducto = new SelectList(db.Productos, "IdProducto", "Nombre", entradaMercancia.IdProducto);
            ViewBag.IdProveedor = new SelectList(db.Proveedors, "IdProveedor", "Nombre", entradaMercancia.IdProveedor);
            return View(entradaMercancia);
        }

        // GET: EntradaMercancias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntradaMercancia entradaMercancia = db.EntradaMercancias.Find(id);
            if (entradaMercancia == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdProducto = new SelectList(db.Productos, "IdProducto", "Nombre", entradaMercancia.IdProducto);
            ViewBag.IdProveedor = new SelectList(db.Proveedors, "IdProveedor", "Nombre", entradaMercancia.IdProveedor);
            return View(entradaMercancia);
        }

        // POST: EntradaMercancias/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdEntrada,IdProducto,IdProveedor,FechaEntrada,Cantidad")] EntradaMercancia entradaMercancia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(entradaMercancia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdProducto = new SelectList(db.Productos, "IdProducto", "Nombre", entradaMercancia.IdProducto);
            ViewBag.IdProveedor = new SelectList(db.Proveedors, "IdProveedor", "Nombre", entradaMercancia.IdProveedor);
            return View(entradaMercancia);
        }

        // GET: EntradaMercancias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntradaMercancia entradaMercancia = db.EntradaMercancias.Find(id);
            if (entradaMercancia == null)
            {
                return HttpNotFound();
            }
            return View(entradaMercancia);
        }

        // POST: EntradaMercancias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EntradaMercancia entradaMercancia = db.EntradaMercancias.Find(id);
            db.EntradaMercancias.Remove(entradaMercancia);
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
