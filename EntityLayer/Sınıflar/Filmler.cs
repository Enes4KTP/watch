using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Sınıflar
{
    public class Filmler
    {
        [Key]
        public int Id { get; set; }
        public string FilmAdi { get; set; }
        public string FilmGorsel { get; set; }
        public string FilmAciklama { get; set; }
        public string FilmLink { get; set; }
        public FilmTur FilmTur { get; set; }
    }
}
