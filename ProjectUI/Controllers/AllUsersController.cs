using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ProjectUI.Controllers
{
    [Authorize(Roles = "admin")]
    public class AllUsersController : Controller
    {
        AllUsersManager allusersmanager = new AllUsersManager(new EFAllUsersRepository());
        public IActionResult Index()
        {
            var values = allusersmanager.GetListAllUsers();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateAllUsers()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAllUsers(AllUsers p)
        {
            allusersmanager.TAdd(p);
            return RedirectToAction("Index", "AllUsers");
        }
        [HttpGet]
        public IActionResult UpdateAllUsers(int id)
        {
            var values = allusersmanager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateAllUsers(AllUsers p)
        {
            allusersmanager.TUpdate(p);
            return RedirectToAction("Index", "AllUsers");
        }
        [HttpGet]
        public IActionResult DeleteAllUsers(int id)
        {
            var values = allusersmanager.TGetByID(id);
            allusersmanager.TDelete(values);
            return RedirectToAction("Index", "AllUsers");
        }
    }
}
