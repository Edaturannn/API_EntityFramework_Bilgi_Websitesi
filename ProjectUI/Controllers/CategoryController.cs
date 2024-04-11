using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProjectUI.Controllers
{
    [Authorize(Roles = "admin")]
    public class CategoryController : Controller
    {
        CategoryManager categorymanager = new CategoryManager(new EFCategoryRepository());
        public IActionResult Index()
        {
            var values = categorymanager.GetListAllCategory();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(Category p)
        {
            categorymanager.TAdd(p);
            return RedirectToAction("Index", "Category");
        }
        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var values = categorymanager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category p)
        {
            categorymanager.TUpdate(p);
            return RedirectToAction("Index", "Category");
        }
        [HttpGet]
        public IActionResult DeleteCategory(int id)
        {
            var values = categorymanager.TGetByID(id);
            categorymanager.TDelete(values);
            return RedirectToAction("Index", "Category");
        }
    }
}
