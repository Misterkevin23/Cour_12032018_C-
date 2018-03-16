using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class CoucouController : Controller
    {
        // GET: Coucou
        public ActionResult Index()
        {
            ViewBag.Hello = "Coucou les Devs";
            return View();
        }

        public string Test()
        {
            return "<h1>C'est que du bonheur </h1>";
        }
    }
}