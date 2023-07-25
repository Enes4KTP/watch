using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Sınıflar
{
    public class Diziler
    {
        [Key]
        public int Id { get; set; }
        public string DiziAdi { get; set; }
        public string DiziGorsel { get; set; }
        public string DiziAciklama { get; set; }
        public DiziTur? DiziTur { get; set; }
    }
}
