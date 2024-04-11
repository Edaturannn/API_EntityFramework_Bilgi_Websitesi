using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProjectUI.Controllers
{
    [Authorize(Roles = "admin")]
    public class GaleryController : Controller
    {
        GaleryManager galerymanager = new GaleryManager(new EFGaleryRepository());
        public IActionResult Index()
        {
            var values = galerymanager.GetListAllGalery();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateGalery()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateGalery(Galery p)
        {
            galerymanager.TAdd(p);
            return RedirectToAction("Index", "Galery");
        }
        [HttpGet]
        public IActionResult UpdateGalery(int id)
        {
            var values = galerymanager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateGalery(Galery p)
        {
            galerymanager.TUpdate(p);
            return RedirectToAction("Index", "Galery");
        }
        public IActionResult DeleteGalery(int id)
        {
            var values = galerymanager.TGetByID(id);
            galerymanager.TDelete(values);
            return RedirectToAction("Index", "Galery");
        }
    }
}
