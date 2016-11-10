using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Quiz2Airport.Models;

namespace Quiz2Airport.Content
{
    public class TravelsController : Controller
    {
        private TravelContext db = new TravelContext();

        // GET: Travels
        //public ActionResult Index()
        //{
        //    return View(db.Travels.ToList());
        //}
        public ActionResult Index(string comfortClass, string searchString)
        {
            var ComfortLst = new List<ComfortClass>();

            var ComfortQry = from d in db.Travels
                             orderby d.Comfort
                             select d.Comfort;

            ComfortLst.AddRange(ComfortQry.Distinct());
            ViewBag.comfortClass = new SelectList(ComfortLst);

            var travels = from m in db.Travels
                         select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                travels = travels.Where(s => (s.FromAirport.Contains(searchString) || s.ToAirport.Contains(searchString)));
            }

            if (!string.IsNullOrEmpty(comfortClass))
            {
                ComfortClass ComfortClassCast;
                Enum.TryParse(comfortClass, out ComfortClassCast);
                travels = travels.Where(x => x.Comfort == ComfortClassCast);
            }

            return View(travels);
        }

        // GET: Travels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Travel travel = db.Travels.Find(id);
            if (travel == null)
            {
                return HttpNotFound();
            }
            return View(travel);
        }

        // GET: Travels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Travels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Age,PassportNo,DateDeparture,DateArrival,FromAirport,ToAirport,Comfort")] Travel travel)
        {
            if (ModelState.IsValid && (travel.DateDeparture < travel.DateArrival))
            {
                db.Travels.Add(travel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(travel);
        }

        // GET: Travels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Travel travel = db.Travels.Find(id);
            if (travel == null)
            {
                return HttpNotFound();
            }
            return View(travel);
        }

        // POST: Travels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Age,PassportNo,DateDeparture,DateArrival,FromAirport,ToAirport,Comfort")] Travel travel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(travel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(travel);
        }

        // GET: Travels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Travel travel = db.Travels.Find(id);
            if (travel == null)
            {
                return HttpNotFound();
            }
            return View(travel);
        }

        // POST: Travels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Travel travel = db.Travels.Find(id);
            db.Travels.Remove(travel);
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
