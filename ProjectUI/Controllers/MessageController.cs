using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProjectUI.Controllers
{
    [Authorize(Roles = "admin")]
    public class MessageController : Controller
    {
        ContactManager contactmanager = new ContactManager(new EFContactRepository());
        public IActionResult Index()
        {
            var values = contactmanager.GetListAllContact();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateMessage(Contact p)
        {
            contactmanager.TAdd(p);
            return RedirectToAction("Index", "Message");
        }
        [HttpGet]
        public IActionResult UpdateMessage(int id)
        {
            var values = contactmanager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateMessage(Contact p)
        {
            contactmanager.TUpdate(p);
            return RedirectToAction("Index", "Message");
        }
        [HttpGet]
        public IActionResult DeleteMessage(int id)
        {
            var values = contactmanager.TGetByID(id);
            contactmanager.TDelete(values);
            return RedirectToAction("Index", "Message");
        }
    }
}
