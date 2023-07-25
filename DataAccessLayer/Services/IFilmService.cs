using EntityLayer.Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services
{
	public interface IFilmService
	{
		List<Filmler> FilmleriListele();
		void FilmEkle(Filmler filmler);
		void FilmSil(int id);
		void FilmGuncelle(Filmler filmler);
	}
}
