using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCPeopleEF.DAL;
using MVCPeopleEF.Models;

namespace MVCPeopleEF.Controllers
{
    public class PersonModelsController : Controller
    {
        private PersonContext db = new PersonContext();

        // GET: PersonModels
        public ActionResult Index(string personGender, string searchString)
        {
            var GenderLst = new List<Gender>();

            var GenderQry = from d in db.People
                           orderby d.Gender
                           select d.Gender;

            GenderLst.AddRange(GenderQry.Distinct());
            ViewBag.personGender = new SelectList(GenderLst);

            var people = from m in db.People 
                select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                people = people.Where(s => s.Name.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(personGender))
            {
                people = people.Where(x => x.Gender.ToString() == personGender);
            }

            return View(people);
        }

        // GET: PersonModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonModel personModel = db.People.Find(id);
            if (personModel == null)
            {
                return HttpNotFound();
            }
            return View(personModel);
        }

        // GET: PersonModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Age,PostalCode,Gender,BirthDate")] PersonModel personModel)
        {
            if (ModelState.IsValid)
            {
                db.People.Add(personModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personModel);
        }

        // GET: PersonModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonModel personModel = db.People.Find(id);
            if (personModel == null)
            {
                return HttpNotFound();
            }
            return View(personModel);
        }

        // POST: PersonModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Age,PostalCode,Gender,BirthDate")] PersonModel personModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personModel);
        }

        // GET: PersonModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonModel personModel = db.People.Find(id);
            if (personModel == null)
            {
                return HttpNotFound();
            }
            return View(personModel);
        }

        // POST: PersonModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PersonModel personModel = db.People.Find(id);
            db.People.Remove(personModel);
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
