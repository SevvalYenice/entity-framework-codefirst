using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _36504122010.Models.sınıflar;

namespace _36504122010.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
      
        List<Otomobil> liste = new List<Otomobil>()
        {
            new Otomobil {Id=1, Model="Mercedes", Kodu=123, Fiyat=1234555, Aciklama="Acil Satılık",SatistaMi=true},
            new Otomobil {Id=2, Model="BMW", Kodu=456, Fiyat=12345555, Aciklama="Acil Satılık",SatistaMi=true},
            new Otomobil {Id=3, Model="Audi", Kodu=678, Fiyat=34454555, Aciklama="Satıldı",SatistaMi=false},
            new Otomobil {Id=4, Model="Mini Cooper", Kodu=168, Fiyat=124555, Aciklama="Satıldı",SatistaMi=false},

        };



        // GET: Kategori
        public ActionResult Index()
        {
            return View(liste);
        }

        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Otomobil o)
        {
            var maxId = liste.Max(a => a.Id);
            o.Id = maxId + 1;
            liste.Add(o);
            return View("Index", liste.Where(x => x.SatistaMi == true));
        }
        public ActionResult Otomobil()
        {
            List<string> otomobiller = new List<string>()
            {
                "Mercedes","BMW","AUDİ","MiniCooper"
            };
            return View(otomobiller);
        }

    }
}