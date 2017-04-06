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
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Song = db.Songs.Select(i => i.Id);
            if (Song == null)
            {
                return HttpNotFound();
            }
            return View(Song);
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
