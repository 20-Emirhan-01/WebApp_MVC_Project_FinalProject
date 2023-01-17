namespace WebApp_MVC_Project.Models
{
    public class Personel 
    {
        public int Id { get; set; }
        public String Ad { get; set; }
        public String Soyad { get; set; }
        public String Gorevi { get; set; }
        public String YonetimTip11 { get; set; } // İdare
        public String YonetimTip12 { get; set; } // Öğretmen
        public String YonetimTip13 { get; set; } // Öğrenci işleri
    }
}
