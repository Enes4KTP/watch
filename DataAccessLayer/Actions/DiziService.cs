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
	public class DiziService : IDiziService
	{
		readonly watchDbContext c = new watchDbContext();

		public List<Diziler> DizileriListele()
		{
			var degerler = c.Dizilers.Include(f => f.DiziTur).ToList();
			return c.Dizilers.ToList();
		}

		public void DiziEkle(Diziler diziler)
		{
			var diziTur = c.DiziTurs.FirstOrDefault(dt => dt.Id == diziler.DiziTur.Id);
			diziler.DiziTur = diziTur;

			c.Dizilers.Add(diziler);
			c.SaveChanges();
		}

		public void DiziSil(int id)
		{
			var dizi = c.Dizilers.Find(id);
			if (dizi != null)
			{
				c.Dizilers.Remove(dizi);
				c.SaveChanges();
			}
		}

		public void DiziGuncelle(Diziler diziler)
		{
			var dizi = c.Dizilers.Find(diziler.Id);
			if (dizi != null)
			{
				dizi.DiziAdi = diziler.DiziAdi;
				dizi.DiziGorsel = diziler.DiziGorsel;
				dizi.DiziAciklama = diziler.DiziAciklama;
				var diziTur = c.DiziTurs.FirstOrDefault(dt => dt.Id == diziler.DiziTur.Id);
				dizi.DiziTur = diziTur;

				c.SaveChanges();
			}
		}
	}
}
