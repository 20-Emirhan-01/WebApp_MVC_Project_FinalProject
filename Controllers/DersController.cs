using Microsoft.AspNetCore.Mvc;
using WebApp_MVC_Project.Models;

namespace WebApp_MVC_Project.Controllers
{
    public class DersController : Controller
    {
        public IActionResult DersSayfası()
        {
            return View();
        }
        public IActionResult Yeni()
        {
            return View();
        }
        public IActionResult DersDetay(int id)
        {
            var r = Models.DersVeri.Dersler.FirstOrDefault(x => x.Id == id);
            return View(r);
        }

        public IActionResult DersSil(int id)
        {
            var r = Models.DersVeri.Dersler.FirstOrDefault(x => x.Id == id);
            Models.DersVeri.Dersler.Remove(r);
            return RedirectToAction("Listele");
        }

        [HttpPost]
        public IActionResult Yeni(Ders ders)
        {
            Models.DersVeri.Dersler.Add(ders);
            return RedirectToAction("Listele");
        }
        public IActionResult Guncelle(Ders ders)
        {
            var r = Models.DersVeri.Dersler.FirstOrDefault(x => x.Id == ders.Id);
            Models.DersVeri.Dersler.Remove(r);
            Models.DersVeri.Dersler.Add(ders);
            return RedirectToAction("Listele");
        }
        public IActionResult Listele()
        {
            return View(Models.DersVeri.Dersler);
        }


    }
}
