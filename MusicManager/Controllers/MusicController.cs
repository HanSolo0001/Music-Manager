using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MusicManager.Models;
using MusicManager.Context;
using System.Net;

namespace MusicManager.Controllers
{
    public class MusicController : Controller
    {
        SongDatabase db = new SongDatabase();

        // GET: Songs
        [HttpGet]
        public ActionResult Index()
        {
            List<Song> songs = db.Songs                
                .ToList();

            return View(songs);
        }

        // GET: Songs/Add/5
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        // POST: Songs/Add/5
       [HttpPost]
        public ActionResult Add(Song song)
        {
                db.Songs.Add(song);
                db.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Songs/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Song = db.Songs.Where(i => i.Id == id).FirstOrDefault();
            if (Song == null)
            {
                return HttpNotFound();
            }
            return View(Song);
        }

        // POST: Songs/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "ID,SongName,ArtistName,AlbumName,Duration,Exclude")] Song song)
        {
            if (ModelState.IsValid)
            {
                db.Entry(song).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(song);
        }

        // GET: Songs/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Song = db.Songs.Where(i => i.Id == id).FirstOrDefault();
            if (Song == null)
            {
                return HttpNotFound();
            }
            return View(Song);
        }

        // POST: Songs/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Song song)
        {
                Song Song = db.Songs.Where(i => i.Id == id).FirstOrDefault();
                db.Songs.Remove(Song);
                db.SaveChanges();
                return RedirectToAction("Index");
        }
    }
}
