using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SayHello.Controllers
{
    public class HelloAgainController : Controller
    {
        // GET: HelloAgain
        public ActionResult Index()
        {
            return View();
        }
    }
}