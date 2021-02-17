using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using dd106516MIS4200.DAL;
using dd106516MIS4200.Models;

namespace dd106516MIS4200.Controllers
{
    public class BestPicturesController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: BestPictures
        public ActionResult Index()
        {
            return View(db.bestPicture.ToList());
        }

        // GET: BestPictures/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BestPicture bestPicture = db.bestPicture.Find(id);
            if (bestPicture == null)
            {
                return HttpNotFound();
            }
            return View(bestPicture);
        }

        // GET: BestPictures/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BestPictures/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "bestPictureID,movieID,year,winner")] BestPicture bestPicture)
        {
            if (ModelState.IsValid)
            {
                db.bestPicture.Add(bestPicture);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bestPicture);
        }

        // GET: BestPictures/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BestPicture bestPicture = db.bestPicture.Find(id);
            if (bestPicture == null)
            {
                return HttpNotFound();
            }
            return View(bestPicture);
        }

        // POST: BestPictures/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "bestPictureID,movieID,year,winner")] BestPicture bestPicture)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bestPicture).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bestPicture);
        }

        // GET: BestPictures/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BestPicture bestPicture = db.bestPicture.Find(id);
            if (bestPicture == null)
            {
                return HttpNotFound();
            }
            return View(bestPicture);
        }

        // POST: BestPictures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BestPicture bestPicture = db.bestPicture.Find(id);
            db.bestPicture.Remove(bestPicture);
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
