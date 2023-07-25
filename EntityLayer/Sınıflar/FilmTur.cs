using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Sınıflar
{
    public class FilmTur
    {
        [Key]
        public int Id { get; set; } 
        public string FilmTurAd { get; set; }
        public ICollection<Filmler> Filmers { get; set; }

        public ICollection<Yakindakiler> Yakindakilers { get; set; }

        public ICollection<YeniFilmler> YeniFilmlers { get; set; }

    }
}
