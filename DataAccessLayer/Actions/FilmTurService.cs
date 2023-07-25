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
    public class FilmTurService : IFilmTurService
    {
        private readonly watchDbContext c;

        public FilmTurService(watchDbContext dbContext)
        {
            c = dbContext;
        }

        public List<FilmTur> FilmTurleriListele()
        {
            return c.FilmTurs.ToList();
        }
    }
}
