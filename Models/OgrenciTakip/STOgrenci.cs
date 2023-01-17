using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApp_MVC_Project.Models.OgrenciTakip
{
    public class STOgrenci
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Ad Soyad")]
        public string AdSoyad { get; set; }

        [Required]
        [DisplayName("Bölüm")]
        public Bolumler Bolum { get; set; }

        [Required]
        [DisplayName("Doğum Tarih")]
        public DateTime DogumTarih { get; set; }

        [Required]
        [DisplayName("Giriş Tarih")]
        public int GirisTarih { get; set; }

        [Required]
        [DisplayName("Cep Telefonu")]
        [MinLength(10, ErrorMessage = "10 Karakterden küçük olamaz !!")]
        public string Gsm { get; set; }


        public enum Bolumler : int
        {
            None = 0,
            BilgisayarProgramlama = 1,
            MobilProgramlama = 2,
            GorselProgramlama = 3,
            DatabaseProgramlama = 4,
        }
    }
}

