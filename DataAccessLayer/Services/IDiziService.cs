using EntityLayer.Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services
{
	public interface IDiziService
	{
		List<Diziler> DizileriListele();
		void DiziEkle(Diziler diziler);
		void DiziSil(int id);
		void DiziGuncelle(Diziler diziler);
	}
}
