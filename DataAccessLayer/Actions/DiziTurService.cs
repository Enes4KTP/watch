using DataAccessLayer.Data;
using DataAccessLayer.Services;
using EntityLayer.Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Actions
{
	public class DiziTurService : IDiziTurService
	{
		private readonly watchDbContext c;

		public DiziTurService(watchDbContext dbContext)
		{
			c = dbContext;
		}

		public List<DiziTur> DiziTurleriListele()
		{
			return c.DiziTurs.ToList();
		}

	}
}
