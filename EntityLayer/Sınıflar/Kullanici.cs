using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Sınıflar
{
    public class Kullanici
    {
        [Key]
        public int Id { get; set; }
        public string KullaniciAd { get; set; }
        public string KullaniciSoyad { get; set; }
        public string KullaniciEmail { get; set; }
        public string KullaniciSifre { get; set; }

    }
}
