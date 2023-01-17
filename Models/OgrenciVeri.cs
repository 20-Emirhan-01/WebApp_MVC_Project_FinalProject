using WebApp_MVC_Project.Models;

namespace WebApp_MVC_Project.Models
{
    public class OgrenciVeri
    {
        public static List<Ogrenci> Ogrenciler = new List<Ogrenci>()
        {
            new Ogrenci()
            {
                Id = 1,
                Ad = "Emircan",
                Soyad = "Yıldız",
                KayitTarih = "12/08/2018",
                ÖgrenciNo = "20200109053",
                DogumTarihi = "09 / 06 / 1999",
                Bolum = "BILGISAYAR PROGRAMCILIGI",
            },
            new Ogrenci()
            {
                Id = 2,
                Ad = "Yavuz",
                Soyad = "Parlak",
                KayitTarih = "15/07/2018",
                ÖgrenciNo = "20200108076",
                DogumTarihi = "10 / 09 / 1997",
                Bolum = "BILGISAYAR PROGRAMCILIGI",
            },
            new Ogrenci()
            {
                Id = 3,
                Ad = "Melih",
                Soyad = "Aslan",
                KayitTarih = "22/07/2018",
                ÖgrenciNo = "20200109026",
                DogumTarihi = "02 / 02 / 1997",
                Bolum = "BILGISAYAR PROGRAMCILIGI",
            },
            new Ogrenci()
            {
                Id = 4,
                Ad = "Ayşe",
                Soyad = "Korkut",
                KayitTarih = "18/08/2018",
                ÖgrenciNo = "20200105069",
                DogumTarihi = "24 / 04 / 1998",
                Bolum = "BILGISAYAR PROGRAMCILIGI",
            }
        };
     
    }
}
