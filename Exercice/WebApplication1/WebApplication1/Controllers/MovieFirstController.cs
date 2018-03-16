using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class MovieFirstController : Controller
    {
        public List<Models.Movie> movies;

        private void GenerateMovie()
        {
            movies = new List<Models.Movie>
            {
                new Models.Movie{ID=1, Title="StarWars", Genre="SF", Price=10, ReleaseDate= new DateTime(1977, 12,11) },
                new Models.Movie{ID=2, Title="Seigneur des anneaux", Genre="SF", Price=5, ReleaseDate= new DateTime(2001, 12,19) },
            };
        
        }

        // GET: MovieFirst
        public ActionResult Index()
        {
            GenerateMovie();
            return View(movies);
        }

        // GET: MovieFirst/Details/5
        public ActionResult Details(int id)
        {
            GenerateMovie();
            var m = movies.Where(MvcApplication => MvcApplication.ID == id).FirstOrDefault();
            return View(m);
        }

        // GET: MovieFirst/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovieFirst/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieFirst/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MovieFirst/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieFirst/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MovieFirst/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
