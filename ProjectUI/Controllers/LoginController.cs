using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using ProjectUI.Models;
using EntityLayer.Concrete;

namespace ProjectUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly Context _context;
        private readonly IConfiguration _configuration;
        public LoginController(Context context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                AllUsers AllUsers = _context.AllUsers.SingleOrDefault(x => x.namesurname.ToLower() == model.NameSurname.ToLower() && x.password == model.Password);
                if (AllUsers != null)
                {
                    if (AllUsers.locked == false)
                    {
                        ModelState.AddModelError(nameof(model.NameSurname), "Kullanıcı Pasif Lütfen Farklı Bir İsim Giriniz!!!");
                        return View(model);
                    }
                    List<Claim> claims = new List<Claim>();
                    claims.Add(new Claim(ClaimTypes.NameIdentifier, AllUsers.allusersid.ToString()));
                    claims.Add(new Claim(ClaimTypes.Name, AllUsers.namesurname.ToString()));
                    claims.Add(new Claim(ClaimTypes.Name, AllUsers.namesurname ?? string.Empty));
                    claims.Add(new Claim(ClaimTypes.Role, AllUsers.role));
                    claims.Add(new Claim("NameSurname", AllUsers.namesurname));

                    ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    ClaimsPrincipal principal = new ClaimsPrincipal(identity);

                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                    if (AllUsers.role == "user")
                    {
                        return RedirectToAction("Index", "UsersHome");
                    }
                    else if (AllUsers.role == "admin")
                    {
                        return RedirectToAction("Index", "AdminsHome");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Kullanıcı Adı Veya Şifre Hatalı Lütfen Tekradan Deneyiniz!!!");
                }
            }
            return View(model);
        }
    }
}
