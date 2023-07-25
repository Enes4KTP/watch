using DataAccessLayer.Data;
using DataAccessLayer.Services;
using EntityLayer.Sınıflar;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Actions
{
	public class YFilmService : IYFilmService
	{
		readonly watchDbContext c = new watchDbContext();

		public List<YeniFilmler> YFilmListele()
		{
			var degerler = c.YeniFilmers.Include(f => f.FilmTur).ToList();
			return c.YeniFilmers.ToList();
		}

		public void YFilmEkle(YeniFilmler filmler)
		{
			var filmTur = c.FilmTurs.FirstOrDefault(ft => ft.Id == filmler.FilmTur.Id);
			filmler.FilmTur = filmTur;

			c.YeniFilmers.Add(filmler);
			c.SaveChanges();
		}

		public void YFilmSil(int id)
		{
			var film = c.YeniFilmers.Find(id);
			if (film != null)
			{
				c.YeniFilmers.Remove(film);
				c.SaveChanges();
			}
		}

		public void YFilmGuncelle(YeniFilmler filmler)
		{
			var film = c.YeniFilmers.Find(filmler.Id);
			if (film != null)
			{
				film.YFilmAdi = filmler.YFilmAdi;
				film.YFilmGorsel = filmler.YFilmGorsel;
				film.YFilmAciklama = filmler.YFilmAciklama;
				film.YFilmLink = filmler.YFilmLink;
				var filmTur = c.FilmTurs.FirstOrDefault(ft => ft.Id == filmler.FilmTur.Id);
				film.FilmTur = filmTur;

				c.SaveChanges();
			}
		}
	}
}
