using EntityLayer.Sınıflar;

namespace watchMVCProject.Models.ViewModel
{
	public class IndexViewModel
	{
		public List<Filmler> Filmers { get; set; }
		public List<YeniFilmler> YeniFilmlers { get; set; }
		public List<Yakindakiler> Yakindakilers { get; set; }
		public List<Diziler> Dizilers { get; set; }
	}
}
