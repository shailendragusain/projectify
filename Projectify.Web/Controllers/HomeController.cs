using Projectify.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projectify.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            ViewBag.AccessRule = new AccessRule
            {
                Person = new Person
                {
                    Name = "Test"
                }
            };
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View("About");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
