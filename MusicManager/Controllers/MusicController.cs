using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MusicManager.Models;

namespace MusicManager.Controllers
{
    public class MusicController : Controller
    {
        // SongDatabase db = new SongDatabase();

        // GET: Songs
        public ActionResult Music()
        {
                return View();
        }

        // GET: form to add songs to database by clicking add button
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        // POST: Songs
       [HttpPost]
        public ActionResult Add(Song songs)
        {
            if(ModelState.IsValid)
            {

            }
            SongDatabase.Songs.Add(songs);
            SongDatabase.SaveChanges();

            return RedirectToAction("Music");
        }

        // GET: Songs/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Songs/Edit/5
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

        // GET: Songs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Songs/Delete/5
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
