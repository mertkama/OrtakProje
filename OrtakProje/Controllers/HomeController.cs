using Microsoft.AspNetCore.Mvc;
using OrtakProje.Models;
using System.Collections.Generic;

namespace OrtakProje.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        public int Index3()
        {
            return 24;
        }
        public string Index4()
        {
            return "Merhaba Bugün Hava Çok Soğuk ";
        }
        public IActionResult Index5()
        {
            var ktp = new List<Kitap>()
            {
                new Kitap(){ID=1,KitapAd="80 Günde Devri Alem", Yazar="Jules Verne"},
                new Kitap(){ID=2,KitapAd="Bilinmeyen Bir Kadının" +
                " Mektubu", Yazar="Zweig"},
                new Kitap{ID=3,KitapAd="Bir Noel Hikayesi", Yazar="Charles Dickens"},
                new Kitap(){ID=4,KitapAd="Şeker", Yazar="Vasconceulous"}
            };
            return View(ktp);
        }
        public IActionResult Index6()
        {
            ViewBag.deger1 = "Merhaba Core Dersleri Devam Ediyor";
            ViewBag.deger2 = "Sizden bir ricam var";
            ViewBag.deger3 = "Murat hocaya 2022'den  selamlar";
            return View();
        }
        public IActionResult Index7()
        {
            return View();
        }
        public IActionResult Index8()
        {
            return View();
        }
        public IActionResult Index9()
        {
            return View();
        }
    }
}
