using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
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
            return "<h1>leuul</h1>";
        }
    }
}