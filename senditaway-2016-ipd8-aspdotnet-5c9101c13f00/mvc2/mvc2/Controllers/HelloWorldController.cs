using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc2.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name, int id = 1)
        {
            //return HttpUtility.HtmlEncode("Welcome " + name + ". Number of times: " + id);
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = id;

            return View();
        }
    }
}