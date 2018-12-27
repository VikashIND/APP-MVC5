using MVC5_APP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5_APP.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult RandomMovie()
        {
            var movie = new Movie { Id = 1, Name = "My Movie" };
            return View(movie);
        }
    }
}