using EntityLayer.Sınıflar;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data
{
	public class watchDbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=LAPTOP-GDI4675J;database=WatchDb; integrated security=true;TrustServerCertificate=True");
		}

		public DbSet<Diziler> Dizilers { get; set; }
		public DbSet<DiziTur> DiziTurs { get; set; }
		public DbSet<Filmler> Filmers { get; set; }
		public DbSet<FilmTur> FilmTurs { get; set; }
		public DbSet<Kullanici> Kullanicis { get; set; }
		public DbSet<Yakindakiler> Yakindakilers { get; set; }
		public DbSet<YeniFilmler> YeniFilmers { get; set; }
	}
}
