using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MusicManager.Models;
using MusicManager.Context;

namespace MusicManager.Controllers
{
    public class MusicController : Controller
    {
        SongDatabase db = new SongDatabase();

        // GET: Songs
        [HttpGet]
        public ActionResult Music()
        {
            List<Song> songs = db.Songs                
                .ToList();

            return View(songs);
        }

        // GET: form to add songs to database by clicking add button
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        // POST: Songs
       [HttpPost]
        public ActionResult Add(Song song)
        {
                db.Songs.Add(song);
                db.SaveChanges();

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
