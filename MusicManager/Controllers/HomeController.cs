using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicManager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Music()
        {
            ViewBag.Message = "Below are your current playlists. Click on one to view the songs and artists. Alternatively, you can delete a playlist, or add a new playlist.";
            
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Music Manager is a web app that gives users access to a dynamic music library that lets you add, delete, or modify current artists and song selections in a given playlist. You can also create, delete, or edit a current playlist. In order to use the Music Manager app, please login.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Use this page to contact the developer of this app with any questions or feedback.";

            return View();
        }
    }
}