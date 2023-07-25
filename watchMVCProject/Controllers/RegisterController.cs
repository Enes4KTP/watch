using DataAccessLayer.Data;
using EntityLayer.Sınıflar;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace watchMVCProject.Controllers
{
    public class RegisterController : Controller
    {
        private readonly watchDbContext c;
        public RegisterController(watchDbContext c)
        {
            this.c = c;
        }


        [HttpGet]
        public IActionResult KayitOl()
        {
            var kullanici = c.Kullanicis.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult KayitOl(Kullanici p)
        {
            try
            {
                c.Kullanicis.Add(p);
                c.SaveChanges();
                return RedirectToAction("Index", "Login");
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine(ex.InnerException.Message);
                return View(p);
            }
        }
    }
}
