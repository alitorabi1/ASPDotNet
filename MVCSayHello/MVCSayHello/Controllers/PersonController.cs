using MVCSayHello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSayHello.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Person(PersonModel person)
        //{
        //    ViewBag.Msg = "The Person Name is: " + person.Name + " with " + person.Age + " years old added successfuly.";
        //    return View();
        //}

        [HttpPost]
        public ActionResult Person(PersonModel person)
        {

            return View();
        }
    }
}