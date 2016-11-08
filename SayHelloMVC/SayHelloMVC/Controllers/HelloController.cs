using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SayHelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult PostAction(string nm, int ag)
        {

            return View("Index");
        }

    }
}