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
    public class MoviesController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: Movies
        public ActionResult Index()
        {
            var movie = db.movie.Include(m => m.actor).Include(m => m.bestPicture);
            return View(movie.ToList());
        }

        // GET: Movies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.movie.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // GET: Movies/Create
        public ActionResult Create()
        {
            ViewBag.actorID = new SelectList(db.actor, "actorID", "firstName");
            ViewBag.bestPictureID = new SelectList(db.bestPicture, "bestPictureID", "winner");
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "movieID,movieTitle,description,releaseDate,actorID,bestPictureID")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.movie.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.actorID = new SelectList(db.actor, "actorID", "lastName");
            ViewBag.bestPictureID = new SelectList(db.bestPicture, "bestPictureID", "year");
            return View(movie);
        }

        // GET: Movies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.movie.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            ViewBag.actorID = new SelectList(db.actor, "actorID", "firstName", movie.actorID);
            ViewBag.bestPictureID = new SelectList(db.bestPicture, "bestPictureID", "winner", movie.bestPictureID);
            return View(movie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "movieID,movieTitle,description,releaseDate,actorID,bestPictureID")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.actorID = new SelectList(db.actor, "actorID", "firstName", movie.actorID);
            ViewBag.bestPictureID = new SelectList(db.bestPicture, "bestPictureID", "winner", movie.bestPictureID);
            return View(movie);
        }

        // GET: Movies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.movie.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Movie movie = db.movie.Find(id);
            db.movie.Remove(movie);
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
