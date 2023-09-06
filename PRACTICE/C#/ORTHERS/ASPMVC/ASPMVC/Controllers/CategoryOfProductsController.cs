using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASPMVC.Models;

namespace ASPMVC.Controllers
{
    public class CategoryOfProductsController : Controller
    {
        private ProductDBContext db = new ProductDBContext();

        // GET: CategoryOfProducts
        public ActionResult Index()
        {
            return View(db.CategoryOfProducts.ToList());
        }

        // GET: CategoryOfProducts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoryOfProduct categoryOfProduct = db.CategoryOfProducts.Find(id);
            if (categoryOfProduct == null)
            {
                return HttpNotFound();
            }
            return View(categoryOfProduct);
        }

        // GET: CategoryOfProducts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryOfProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CategoryOfProductID,Description")] CategoryOfProduct categoryOfProduct)
        {
            if (ModelState.IsValid)
            {
                db.CategoryOfProducts.Add(categoryOfProduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoryOfProduct);
        }

        // GET: CategoryOfProducts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoryOfProduct categoryOfProduct = db.CategoryOfProducts.Find(id);
            if (categoryOfProduct == null)
            {
                return HttpNotFound();
            }
            return View(categoryOfProduct);
        }

        // POST: CategoryOfProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CategoryOfProductID,Description")] CategoryOfProduct categoryOfProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoryOfProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoryOfProduct);
        }

        // GET: CategoryOfProducts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoryOfProduct categoryOfProduct = db.CategoryOfProducts.Find(id);
            if (categoryOfProduct == null)
            {
                return HttpNotFound();
            }
            return View(categoryOfProduct);
        }

        // POST: CategoryOfProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CategoryOfProduct categoryOfProduct = db.CategoryOfProducts.Find(id);
            db.CategoryOfProducts.Remove(categoryOfProduct);
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
