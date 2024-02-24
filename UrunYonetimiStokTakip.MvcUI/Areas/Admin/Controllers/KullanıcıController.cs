using BL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace UrunYonetimiStokTakip.MvcUI.Areas.Admin.Controllers
{
    public class KullanıcıController : Controller
    {
        KullaniciManager manager = new KullaniciManager();
        // GET: Admin/Kullanıcı
        public ActionResult Index()
        {
            return View(manager.GetAll());
        }

        

        // GET: Admin/Kullanıcı/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Kullanıcı/Create
        [HttpPost]
        public ActionResult Create(Kullanici kullanici)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    
                    var sonuc = manager.Add(kullanici);
                    if (sonuc > 0)
                    {
                        return RedirectToAction("Index");
                    }
                    else ModelState.AddModelError("", "Kayıt Eklenemedi!");
                }
                
            }
            catch
            {
                ModelState.AddModelError("", "Hata Oluştu! Kayıt Eklenemedi!");
            }
            return View();
        }

        // GET: Admin/Kullanıcı/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kullanici kullanici= manager.Get(id.Value);
            if (kullanici == null) { return HttpNotFound(); }
            return View(kullanici); ;
        }

        // POST: Admin/Kullanıcı/Edit/5
        [HttpPost]
        public ActionResult Edit(Kullanici kullanici)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    manager.UpDate(kullanici); return RedirectToAction("Index");
                }
                return View(kullanici);
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Kullanıcı/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kullanici kullanici = manager.Get(id.Value);
            if (kullanici == null) { return HttpNotFound(); }
            return View(kullanici); ;
        }

        // POST: Admin/Kullanıcı/Delete/5
        [HttpPost]
        public ActionResult Delete(int id,FormCollection collection)
        {
            try
            {
                
                manager.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
