using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Sınıflar
{
    public class DiziTur
    {
        [Key]
        public int Id { get; set; }
        public string DiziTurAd { get; set; }
        public ICollection<Diziler>? Dizilers { get; set; }
    }
}
