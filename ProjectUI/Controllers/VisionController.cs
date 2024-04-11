using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProjectUI.Controllers
{
    [Authorize(Roles = "admin")]
    public class VisionController : Controller
    {
        VisionManager visionmanager = new VisionManager(new EFVisionRepository());
        public IActionResult Index()
        {
            var values = visionmanager.GetListAllVision();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateVision()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateVision(Vision p)
        {
            visionmanager.TAdd(p);
            return RedirectToAction("Index", "Vision");
        }
        [HttpGet]
        public IActionResult UpdateVision(int id)
        {
            var values = visionmanager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateVision(Vision p)
        {
            visionmanager.TUpdate(p);
            return RedirectToAction("Index", "Vision");
        }
        [HttpGet]
        public IActionResult DeleteVision(int id)
        {
            var values = visionmanager.TGetByID(id);
            visionmanager.TDelete(values);
            return RedirectToAction("Index", "Vision");
        }
    }
}
