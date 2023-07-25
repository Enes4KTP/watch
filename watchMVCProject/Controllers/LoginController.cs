using DataAccessLayer.Data;
using EntityLayer.Sınıflar;
using Microsoft.AspNetCore.Mvc;
using watchWebSite.Utilities;

namespace watchMVCProject.Controllers
{
    public class LoginController : Controller
    {
        private readonly watchDbContext c;
        public LoginController(watchDbContext c)
        {
            this.c = c;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Kullanici p)
        {
            var bilgi = c.Kullanicis.FirstOrDefault(x => x.KullaniciEmail == p.KullaniciEmail && x.KullaniciSifre == p.KullaniciSifre);

            if (bilgi != null)
            {
                // Kullanıcı bilgileri doğru ise, oturumu başlat ve doğru sayfaya yönlendir
                SessionHelper.SetUserSession(HttpContext, p.KullaniciEmail);

                if (p.KullaniciEmail == "admin@watch.com")
                {
                    // Admin kullanıcı ise, Admin/Index sayfasına yönlendir
                    return RedirectToAction("FilmGoruntule", "Admin");
                }
                else
                {
                    // Diğer kullanıcılar ise, Main/Index sayfasına yönlendir
                    return RedirectToAction("Index", "Main");
                }
            }
            else
            {
                // Kullanıcı bilgileri yanlış ise, hata mesajını görüntüle
                ViewBag.ErrorMessage = "Geçersiz kullanıcı adı veya şifre";
                return View();
            }
        }
    }
}
