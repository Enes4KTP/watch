using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Sınıflar
{
    public class YeniFilmler
    {
        [Key]
        public int Id { get; set; }
        public string YFilmAdi { get; set; }
        public string YFilmGorsel { get; set; }
        public string YFilmAciklama { get; set; }
        public string YFilmLink { get; set; }
        public FilmTur FilmTur { get; set; }
    }
}
