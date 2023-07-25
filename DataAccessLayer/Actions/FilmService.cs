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
    public class FilmService : IFilmService
    {
        readonly watchDbContext c = new watchDbContext();

        public List<Filmler> FilmleriListele()
        {
            var degerler = c.Filmers.Include(f => f.FilmTur).ToList();
            return c.Filmers.ToList();
        }

        public void FilmEkle(Filmler filmler)
        {
            var filmTur = c.FilmTurs.FirstOrDefault(ft => ft.Id == filmler.FilmTur.Id);
            filmler.FilmTur = filmTur;
            c.Filmers.Add(filmler);
            c.SaveChanges();
        }

        public void FilmSil(int id)
        {
            var film = c.Filmers.Find(id);
            if (film != null)
            {
                c.Filmers.Remove(film);
                c.SaveChanges();
            }
        }

		public void FilmGuncelle(Filmler filmler)
		{
			var film = c.Filmers.Find(filmler.Id);
			if (film != null)
			{
				film.FilmAdi = filmler.FilmAdi;
				film.FilmGorsel = filmler.FilmGorsel;
				film.FilmAciklama = filmler.FilmAciklama;
				film.FilmLink = filmler.FilmLink;
				var filmTur = c.FilmTurs.FirstOrDefault(ft => ft.Id == filmler.FilmTur.Id);
				film.FilmTur = filmTur;

				c.SaveChanges();
			}
		}
	}
}
