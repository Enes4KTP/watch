using DataAccessLayer.Actions;
using DataAccessLayer.Services;
using Microsoft.AspNetCore.Mvc;
using watchMVCProject.Models.ViewModel;

namespace watchMVCProject.Controllers
{
	public class MainController : Controller
	{
		private readonly IFilmService filmService;
		private readonly IDiziService diziService;
		private readonly IYFilmService yFilmService;
		private readonly IYakinService yakinService;

		public MainController(IFilmService filmService, IDiziService diziService, IYFilmService yFilmService, IYakinService yakinService)
		{
			this.filmService = filmService;
			this.diziService = diziService;
			this.yFilmService = yFilmService;
			this.yakinService = yakinService;
		}

		public IActionResult Index()
		{
			var filmListesi = filmService.FilmleriListele();
			var diziListesi = diziService.DizileriListele();
			var yfilmListesi = yFilmService.YFilmListele();
			var yakinListesi = yakinService.YakinListele();

			var viewModel = new IndexViewModel
			{
				Filmers = filmListesi,
				Dizilers = diziListesi,
				YeniFilmlers = yfilmListesi,
				Yakindakilers = yakinListesi,
				
			};

			return View(viewModel);
		}

        public IActionResult Info()
        {
            return View();
        }

    }
}
