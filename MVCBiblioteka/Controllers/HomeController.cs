using MVCBiblioteka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBiblioteka.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext libraryDB = new ApplicationDbContext();
        //
        // GET: /Store/

        public ActionResult Index()
        {
            var genres = libraryDB.Categories.ToList();

            return View(genres);
        }

        //
        // GET: /Store/Browse?genre=Disco

        public ActionResult Browse(string genre)
        {
            // Retrieve Genre and its Associated Albums from database
            var genreModel = libraryDB.Categories.Include("Books")
                .Single(g => g.name == genre);

            return View(genreModel);
        }

        //
        // GET: /Store/Details/5

        public ActionResult Details(int id)
        {
            var album = libraryDB.Books.Find(id);

            return View(album);
        }

        //
        // GET: /Store/GenreMenu

        [ChildActionOnly]
        public ActionResult GenreMenu()
        {
            var genres = libraryDB.Categories.ToList();

            return PartialView(genres);
        }
    }
}