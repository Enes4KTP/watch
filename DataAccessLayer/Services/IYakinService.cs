using EntityLayer.Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services
{
	public interface IYakinService
	{
		List<Yakindakiler> YakinListele();
		void YakinEkle(Yakindakiler yakindaki);
		void YakinSil(int id);
		void YakinGuncelle(Yakindakiler yakindaki);
	}
}
