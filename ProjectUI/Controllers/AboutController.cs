using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProjectUI.Controllers
{
    [Authorize(Roles = "admin")]
    public class AboutController : Controller
    {
        AboutManager aboutmanager = new AboutManager(new EFAboutRepository());
        public IActionResult Index()
        {
            var values = aboutmanager.GetListAllAbout();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAbout(About p)
        {
            aboutmanager.TAdd(p);
            return RedirectToAction("Index", "About");
        }
        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var values = aboutmanager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateAbout(About p)
        {
            aboutmanager.TUpdate(p);
            return RedirectToAction("Index", "About");
        }
        [HttpGet]
        public IActionResult DeleteAbout(int id)
        {
            var values = aboutmanager.TGetByID(id);
            aboutmanager.TDelete(values);
            return RedirectToAction("Index", "About");
        }
    }
}
