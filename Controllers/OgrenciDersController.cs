using Microsoft.AspNetCore.Mvc;
using WebApp_MVC_Project.Models;

namespace WebApp_MVC_Project.Controllers
{
    public class OgrenciDersController : Controller
    {
        public IActionResult OgrenciDersSayfası()
        {
            return View();
        }
        public IActionResult Yeni()
        {
            return View();
        }
        public IActionResult OgrenciDersDetay(int id)
        {
            var r = Models.OgrenciDersVeri.OgrenciDersl.FirstOrDefault(x => x.Id == id);
            return View(r);
        }

        public IActionResult OgrenciDersSil(int id)
        {
            var r = Models.OgrenciDersVeri.OgrenciDersl.FirstOrDefault(x => x.Id == id);
            Models.OgrenciDersVeri.OgrenciDersl.Remove(r);
            return RedirectToAction("Listele");
        }
        
        [HttpPost]
        public IActionResult Yeni(OgrenciDers ogrenciders)
        {
            Models.OgrenciDersVeri.OgrenciDersl.Add(ogrenciders);
            return RedirectToAction("Listele");
        }
        [HttpPost]
        public IActionResult Guncelle(OgrenciDers ogrenciders)
        {
            var r = Models.OgrenciDersVeri.OgrenciDersl.FirstOrDefault(x => x.Id == ogrenciders.Id);
            Models.OgrenciDersVeri.OgrenciDersl.Remove(r);
            Models.OgrenciDersVeri.OgrenciDersl.Add(ogrenciders);
            return RedirectToAction("Listele");
        }
        public IActionResult Listele()
        {
            return View(Models.OgrenciDersVeri.OgrenciDersl);
        }


    }
}
