namespace WebApp_MVC_Project.Models
{
    public class Ders
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int Kredisi { get; set; }
        public string OkulYonetimId { get; set; }  // Öğretim görevlisi

    }
}
