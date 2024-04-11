using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ProjectUI.Controllers
{
    public class UsersHomeController : Controller
    {
        ContactManager contactmanager = new ContactManager(new EFContactRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact p)
        {
            contactmanager.TAdd(p);
            return RedirectToAction("Index", "UsersHome");
        }
    }
}
