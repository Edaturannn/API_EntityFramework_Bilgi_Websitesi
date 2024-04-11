using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using ProjectUI.Models;

namespace ProjectUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly Context _context;
        private readonly IConfiguration _configuration;

        public RegisterController(Context context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (_context.AllUsers.Any(x => x.namesurname.ToLower() == model.NameSurname.ToLower()))
                {
                    ModelState.AddModelError(nameof(model.NameSurname), "Bu İsim Kayıtlı Lütfen Farklı Bir İsim Giriniz");
                    return View(model);

                }
                else
                {
                    if (ModelState.IsValid)
                    {
                        AllUsers allUsers = new()
                        {
                            namesurname = model.NameSurname,
                            password = model.Password
                        };

                        _context.AllUsers.Add(allUsers);
                        int AffectedRowCount = _context.SaveChanges();
                        if (AffectedRowCount == 0)
                        {
                            ModelState.AddModelError("", "Kullanıcı Giriş Yapmadı!!!");
                        }
                        else
                        {
                            return RedirectToAction("Index", "Login");
                        }
                    }
                }
            }
            return View(model);
        }
    }
}