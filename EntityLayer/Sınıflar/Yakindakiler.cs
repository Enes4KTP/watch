using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Sınıflar
{
    public class Yakindakiler
    {
        [Key]
        public int Id { get; set; }
        public string YakinAdi { get; set; }
        public string YakinGorsel { get; set; }
        public string YakinAciklama { get; set; }
        public DateTime YakinTarih { get; set; }
        public FilmTur? FilmTur { get; set; }
    }
}
