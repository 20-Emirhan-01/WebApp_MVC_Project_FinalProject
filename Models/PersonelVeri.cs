namespace WebApp_MVC_Project.Models
{
    public class PersonelVeri
    {
        public static List<Personel> Yöneticiler = new List<Personel>()
        {
            new Personel()
            {
                Id = 1,
                Ad = "Betul",
                Soyad = "SOLMAZ",
                Gorevi = "Ogretmen",
                YonetimTip11 ="None",
                YonetimTip12 ="Ogretmen",
                YonetimTip13 ="None",

            },
            new Personel()
            {
                Id = 2,
                Ad = "Pınar",
                Soyad = "DEMIR",
                Gorevi = "Calısan",
                YonetimTip11 ="None",
                YonetimTip12 ="None",
                YonetimTip13 ="Ogrenci isleri",
            },
            new Personel()
            {
                Id = 3,
                Ad = "Emrah",
                Soyad = "SARICICEK",
                 Gorevi = "Ogretmen",
                YonetimTip11 ="None",
                YonetimTip12 ="Ogretmen",
                YonetimTip13 ="None" ,
            },
            new Personel()
            {
                Id = 4,
                Ad = "Hanifi",
                Soyad = "ARSLAN",
                 Gorevi = "Calısan",
                YonetimTip11 ="İdare",
                YonetimTip12 ="None",
                YonetimTip13 ="None",
            },
        };
    }
}
