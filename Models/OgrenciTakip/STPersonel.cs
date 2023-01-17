using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApp_MVC_Project.Models.OgrenciTakip
{
    public class STPersonel
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Ad Soyad")]
        public string AdSoyad { get; set; }

        [Required]
        [DisplayName("Doğum Tarihi")]
        public DateTime DogumTarih { get; set; }

        [Required]
        //[MaxLength(4, ErrorMessage = "4 Karakterden küçük olamaz !!")]
        //[MaxLength(4, ErrorMessage = "4 Karakterden büyük olamaz !!")]
        [DisplayName("Giriş Yılı")]
        public int GirisTarih { get; set; }

        [DisplayName("Bölüm")]
        [EnumDataType(typeof(Bolumler))]
        public Bolumler Bolum { get; set; }

        public ICollection<STDers> Dersler { get; set; } = new List<STDers>();


        public enum Bolumler : int
        {
            None = 0,
            Idare = 1,
            OgrenciIsleri = 2,
            Muhasebe = 3,
            OgretimGorevlisi = 4,
            Rektorluk = 5,
            InsanKaynaklari = 6
        }

    }
}
