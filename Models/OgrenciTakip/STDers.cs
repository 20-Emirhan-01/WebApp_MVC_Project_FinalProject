using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApp_MVC_Project.Models.OgrenciTakip
{
    public class STDers
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Ad")]
        public string Ad { get; set; }

        [Required]
        [DisplayName("Açıklama")]
        public string Aciklama { get; set; }

        [Required]
        public int Kredi { get; set; }

        public int OgretmenId { get; set; }
        public STPersonel Ogretmen { get; set; }

        [Required]
        [DisplayName("Bölüm")]
        public STOgrenci.Bolumler Bolum { get; set; }

        [Required]
        [DisplayName("Devamsızlık")]
        public int Devamsizlik { get; set; }

        [DisplayName("Toplam Hafta")]
        public int ToplamHafta { get; set; }

        [DisplayName("Başlangıç Tarih")]
        public DateTime BaslangicTarih { get; set; }

        [DisplayName("Bitiş Tarih")]
        public DateTime BitisTarih { get; set; }
    }
}

