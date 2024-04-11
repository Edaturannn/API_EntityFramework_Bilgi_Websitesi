using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProjectUI.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminsHomeController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            ViewBag.AllUsersCount = context.AllUsers.Count();
            ViewBag.CategoryCount = context.Categories.Count();
            ViewBag.GaleryCount = context.Galeries.Count();
            ViewBag.MessageCount = context.Contacts.Count();
            return View();
        }
    }
}
