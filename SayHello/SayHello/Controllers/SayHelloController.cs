using SayHello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SayHello.Controllers
{
    public class SayHelloController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Person person)
        {
            
            if (ModelState.IsValid)
            {
                TempData["person"] = person;
                return RedirectToAction("SayHello");
            }
            
            return View(person);
        }
        public ActionResult SayHello()
        {

            TempData.Keep();
        
            return View();
        }

       
    }

}