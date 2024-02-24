using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BL;
using Entities;
using UrunYonetimiStokTakip.MvcUI.Models;

namespace UrunYonetimiStokTakip.MvcUI.Areas.Admin.Controllers
{
    public class UrunlerController : Controller
    {
        //private DatabaseContext db = new DatabaseContext();
        KategoriManager kategori = new KategoriManager();
        MarkaManager marka = new MarkaManager();
        UrunManager manager = new UrunManager();
        // GET: Admin/Urunler
        public ActionResult Index()
        {
            var urunler = manager.GetAll();
            return View(urunler);
        }

        // GET: Admin/Urunler/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Urun urun = manager.Get(id.Value);
            if (urun == null)
            {
                return HttpNotFound();
            }
            return View(urun);
        }

        // GET: Admin/Urunler/Create
        public ActionResult Create()
        {
            ViewBag.KategoriId = new SelectList(kategori.GetAll(), "Id", "KategoriAdi");
            ViewBag.MarkaId = new SelectList(marka.GetAll(), "Id", "MarkaAdi");
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Urun urun)
        {
            if (ModelState.IsValid)
            {
                manager.Add(urun);
                urun.EklenmeTarihi = System.DateTime.Now;
                return RedirectToAction("Index");
            }

            ViewBag.KategoriId = new SelectList(kategori.GetAll(), "Id", "KategoriAdi", urun.KategoriId);
            ViewBag.MarkaId = new SelectList(marka.GetAll(), "Id", "MarkaAdi",urun.MarkaId);
            return View(urun);
        }

        // GET: Admin/Urunler/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Urun urun = manager.Get(id.Value);
            if (urun == null)
            {
                return HttpNotFound();
            }
            ViewBag.KategoriId = new SelectList(kategori.GetAll(), "Id", "KategoriAdi", urun.KategoriId);
            ViewBag.MarkaId = new SelectList(marka.GetAll(), "Id", "MarkaAdi", urun.MarkaId);
            return View(urun);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Urun urun)
        {
            if (ModelState.IsValid)
            {
                manager.UpDate(urun);

                return RedirectToAction("Index");
            }
            ViewBag.KategoriId = new SelectList(kategori.GetAll(), "Id", "KategoriAdi", urun.KategoriId);
            ViewBag.MarkaId = new SelectList(marka.GetAll(), "Id", "MarkaAdi", urun.MarkaId);
            return View(urun);
        }

        // GET: Admin/Urunler/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Urun urun = manager.Get(id.Value);
            if (urun == null)
            {
                return HttpNotFound();
            }
            return View(urun);
        }

        // POST: Admin/Urunler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Urun urun = manager.Get(id);
            manager.Delete(urun.Id);

            return RedirectToAction("Index");
        }
    }
}
