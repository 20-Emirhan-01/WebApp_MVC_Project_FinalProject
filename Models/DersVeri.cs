using WebApp_MVC_Project.Models;

namespace WebApp_MVC_Project.Models
{
    public class DersVeri
    {
        public static List<Ders> Dersler = new List<Ders>()
        {
            new Ders()
            {
                Id = 1,
                Ad = "ELEKTRONIK",
                Kredisi = 4,
                OkulYonetimId = "Huseyin SAHIN",

            },
            new Ders()
            {
                Id = 2,
                Ad = "DENIZ VE LIMAN ISLETMECILIGINE GIRIS",
                Kredisi = 2,
                OkulYonetimId = "Tevfik Suat ELMACI",
            },
            new Ders()
            {
                Id = 3,
                Ad = "TURK DILI VE EDEBIYATI-I",
                Kredisi = 2,
                OkulYonetimId = "Betul SOLMAZ",
            },
            new Ders()
            {
                Id = 4,
                Ad = "NESNEYE DAYALI PROGRAMLAMA-II",
                Kredisi = 3,
                OkulYonetimId = "Fusun ER",
            },
        };
    }
}
