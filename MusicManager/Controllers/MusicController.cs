using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MusicManager.Context;
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

        // POST: Songs
        [HttpPost]
        public ActionResult Add(SongDatabase song)
        {
            using (var songs = new SongDatabase)
            {
                var music = new AlbumSong { s => s.Song, s => s.Album, s => s.Artist };
            }

            SongDatabase.Song.Add(song);
            SongDatabase.SaveChanges();

                return View();
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
