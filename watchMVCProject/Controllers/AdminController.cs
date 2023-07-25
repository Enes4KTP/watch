using DataAccessLayer.Actions;
using DataAccessLayer.Data;
using DataAccessLayer.Services;
using EntityLayer.Sınıflar;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace watchMVCProject.Controllers
{
	public class AdminController : Controller
	{
        readonly watchDbContext c = new watchDbContext();
        private readonly IFilmService filmService;
        private readonly IFilmTurService filmTurService;
		private readonly IDiziService diziService;
		private readonly IDiziTurService diziTurService;
		private readonly IYFilmService yFilmService;
		private readonly IYakinService yakinService;
        public AdminController(IFilmService filmService, 
							   IFilmTurService filmTurService,
							   IDiziService diziService,
							   IDiziTurService diziTurService,
							   IYFilmService yFilmService,
							   IYakinService yakinService,
							   watchDbContext c)
        {
            this.filmService = filmService;
            this.filmTurService = filmTurService;
			this.diziService = diziService;
			this.diziTurService = diziTurService;
			this.yFilmService = yFilmService;
			this.yakinService = yakinService;
            this.c = c;
        }
		#region Film İşlemleri
		public IActionResult FilmGoruntule()
        {
            var degerler = filmService.FilmleriListele();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult FilmEkle()
        {
            var filmTurleri = filmTurService.FilmTurleriListele();
            ViewBag.FilmTurleri = new SelectList(filmTurleri, "Id", "FilmTurAd");
            return View();
        }

        [HttpPost]
        public IActionResult FilmEkle(Filmler film)
        {
           
                filmService.FilmEkle(film);
                return RedirectToAction("FilmGoruntule","Admin");
           

            var filmTurleri = filmTurService.FilmTurleriListele();
            ViewBag.FilmTurleri = new SelectList(filmTurleri, "Id", "FilmTurAd");
            return View(film);
        }

		public IActionResult FilmSil(int id)
		{
			filmService.FilmSil(id);
			return RedirectToAction("FilmGoruntule", "Admin");
		}

		public IActionResult FilmGetir(int id)
		{
			var getir = c.Filmers.Find(id);

			var filmTurleri = c.FilmTurs.ToList();
			ViewBag.FilmTurleri = new SelectList(filmTurleri, "Id", "FilmTurAd");

			return View("FilmGetir", getir);
		}
		public IActionResult FilmGuncelle(Filmler film)
		{
			filmService.FilmGuncelle(film);
			return RedirectToAction("FilmGoruntule", "Admin");
		}

		#endregion

		#region Dizi İşlemleri
		public IActionResult DiziGoruntule()
		{
			var degerler = diziService.DizileriListele();
			return View(degerler);
		}

		[HttpGet]
		public IActionResult DiziEkle()
		{
			var diziTurleri = diziTurService.DiziTurleriListele();
			ViewBag.DiziTurleri = new SelectList(diziTurleri, "Id", "DiziTurAd");
			return View();
		}

		[HttpPost]
		public IActionResult DiziEkle(Diziler dizi)
		{

			diziService.DiziEkle(dizi);
			return RedirectToAction("DiziGoruntule", "Admin");


			var diziTurleri = diziTurService.DiziTurleriListele();
			ViewBag.DiziTurleri = new SelectList(diziTurleri, "Id", "DiziTurAd");
			return View(dizi);
		}

		public IActionResult DiziSil(int id)
		{
			diziService.DiziSil(id);
			return RedirectToAction("DiziGoruntule", "Admin");
		}

		public IActionResult DiziGetir(int id)
		{
			var getir = c.Dizilers.Find(id);

			var diziTurleri = c.DiziTurs.ToList();
			ViewBag.DiziTurleri = new SelectList(diziTurleri, "Id", "DiziTurAd");

			return View("DiziGetir", getir);
		}
		public IActionResult DiziGuncelle(Diziler diziler)
		{
			diziService.DiziGuncelle(diziler);
			return RedirectToAction("DiziGoruntule", "Admin");
		}

		#endregion

		#region Yeni Filmler İşlemleri
		public IActionResult YFilmGoruntule()
		{
			var degerler = yFilmService.YFilmListele();
			return View(degerler);
		}

		[HttpGet]
		public IActionResult YFilmEkle()
		{
			var filmTurleri = filmTurService.FilmTurleriListele();
			ViewBag.YFilmTurleri = new SelectList(filmTurleri, "Id", "FilmTurAd");
			return View();
		}

		[HttpPost]
		public IActionResult YFilmEkle(YeniFilmler film)
		{

			yFilmService.YFilmEkle(film);
			return RedirectToAction("YFilmGoruntule", "Admin");


			var filmTurleri = filmTurService.FilmTurleriListele();
			ViewBag.FilmTurleri = new SelectList(filmTurleri, "Id", "FilmTurAd");
			return View(film);
		}

		public IActionResult YFilmSil(int id)
		{
			yFilmService.YFilmSil(id);
			return RedirectToAction("YFilmGoruntule", "Admin");
		}

		public IActionResult YFilmGetir(int id)
		{
			var getir = c.YeniFilmers.Find(id);

			var filmTurleri = c.FilmTurs.ToList();
			ViewBag.YFilmTurleri = new SelectList(filmTurleri, "Id", "FilmTurAd");

			return View("YFilmGetir", getir);
		}
		public IActionResult YFilmGuncelle(YeniFilmler film)
		{
			yFilmService.YFilmGuncelle(film);
			return RedirectToAction("YFilmGoruntule", "Admin");
		}

		#endregion

		#region Yakındaki Filmler İşlemleri
		public IActionResult YakinGoruntule()
		{
			var degerler = yakinService.YakinListele();
			return View(degerler);
		}

		[HttpGet]
		public IActionResult YakinEkle()
		{
			var filmTurleri = filmTurService.FilmTurleriListele();
			ViewBag.YFilmTurleri = new SelectList(filmTurleri, "Id", "FilmTurAd");
			return View();
		}

		[HttpPost]
		public IActionResult YakinEkle(Yakindakiler film)
		{

			yakinService.YakinEkle(film);
			return RedirectToAction("YakinGoruntule", "Admin");


			var filmTurleri = filmTurService.FilmTurleriListele();
			ViewBag.FilmTurleri = new SelectList(filmTurleri, "Id", "FilmTurAd");
			return View(film);
		}

		public IActionResult YakinSil(int id)
		{
			yakinService.YakinSil(id);
			return RedirectToAction("YakinGoruntule", "Admin");
		}

		public IActionResult YakinGetir(int id)
		{
			var getir = c.Yakindakilers.Find(id);

			var filmTurleri = c.FilmTurs.ToList();
			ViewBag.YFilmTurleri = new SelectList(filmTurleri, "Id", "FilmTurAd");

			return View("YakinGetir", getir);
		}
		public IActionResult YakinGuncelle(Yakindakiler film)
		{
			yakinService.YakinGuncelle(film);
			return RedirectToAction("YakinGoruntule", "Admin");
		}

		#endregion
	}
}
