using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Index()
        {
            string message = "Hello World";
            return message;
            //return View();
        }

        public string Welcome (string name, int id = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ". Number of times: " + id);
        }
    }
}