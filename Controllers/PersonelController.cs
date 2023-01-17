using Microsoft.AspNetCore.Mvc;
using WebApp_MVC_Project.Models;

namespace WebApp_MVC_Project.Controllers
{
    public class PersonelController : Controller
    {
        public IActionResult Personelsayfası()
        {
            return View();
        }
        public IActionResult Yeni()
        {
            return View();
        }
        public IActionResult PersonelDetay(int id)
        {
            var r = Models.PersonelVeri.Yöneticiler.FirstOrDefault(x => x.Id == id);
            return View(r);
        }

        public IActionResult PersonelSil(int id)
        {
            var r = Models.PersonelVeri.Yöneticiler.FirstOrDefault(x => x.Id == id);
            Models.PersonelVeri.Yöneticiler.Remove(r);
            return RedirectToAction("Listele");
        }

        [HttpPost]
        public IActionResult Yeni(Personel personel)
        {
            Models.PersonelVeri.Yöneticiler.Add(personel);
            return View();
        }
        
        [HttpPost]
        public IActionResult YonetimDetay(Personel personel)
        {
            var r = Models.PersonelVeri.Yöneticiler.FirstOrDefault(x => x.Id == personel.Id);
            Models.PersonelVeri.Yöneticiler.Remove(r);
            Models.PersonelVeri.Yöneticiler.Add(personel);
            return RedirectToAction("Listele");
        }
        public IActionResult listele()
        {
            return View(Models.PersonelVeri.Yöneticiler);
        }
    }
}
