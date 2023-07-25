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
	public class YakinService : IYakinService
	{
		readonly watchDbContext c = new watchDbContext();

		public List<Yakindakiler> YakinListele()
		{
			var degerler = c.Yakindakilers.Include(f => f.FilmTur).ToList();
			return c.Yakindakilers.ToList();
		}

		public void YakinEkle(Yakindakiler filmler)
		{
			var filmTur = c.FilmTurs.FirstOrDefault(ft => ft.Id == filmler.FilmTur.Id);
			filmler.FilmTur = filmTur;

			c.Yakindakilers.Add(filmler);
			c.SaveChanges();
		}

		public void YakinSil(int id)
		{
			var film = c.Yakindakilers.Find(id);
			if (film != null)
			{
				c.Yakindakilers.Remove(film);
				c.SaveChanges();
			}
		}

		public void YakinGuncelle(Yakindakiler filmler)
		{
			var film = c.Yakindakilers.Find(filmler.Id);
			if (film != null)
			{
				film.YakinAdi = filmler.YakinAdi;
				film.YakinGorsel = filmler.YakinGorsel;
				film.YakinAciklama = filmler.YakinAciklama;
				film.YakinTarih = filmler.YakinTarih;
				var filmTur = c.FilmTurs.FirstOrDefault(ft => ft.Id == filmler.FilmTur.Id);
				film.FilmTur = filmTur;

				c.SaveChanges();
			}
		}
	}
}
