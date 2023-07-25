﻿using EntityLayer.Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services
{
	public interface IYFilmService
	{
		List<YeniFilmler> YFilmListele();
		void YFilmEkle(YeniFilmler yeniFilm);
		void YFilmSil(int id);
		void YFilmGuncelle(YeniFilmler yeniFilm);
	}
}
