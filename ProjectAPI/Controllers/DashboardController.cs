using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        AllUsersManager allusersmanager = new AllUsersManager(new EFAllUsersRepository());
        CategoryManager categorymanager = new CategoryManager(new EFCategoryRepository());
        ContactManager contactmanager = new ContactManager(new EFContactRepository());
        GaleryManager galerymanager = new GaleryManager(new EFGaleryRepository());
        [HttpGet("AllUsers")]
        public async Task<IActionResult> AllUsers()
        {
            var values = allusersmanager.GetListAllUsers();
            return Ok(values);
        }

        [HttpGet("Category")]
        public async Task<IActionResult> Category()
        {
            var values = categorymanager.GetListAllCategory();
            return Ok(values);
        }

        [HttpGet("Contact")]
        public async Task<IActionResult> Contact()
        {
            var values = contactmanager.GetListAllContact();
            return Ok(values);
        }

        [HttpGet("Galery")]
        public async Task<IActionResult> Galery()
        {
            var values = galerymanager.GetListAllGalery();
            return Ok(values);
        }
    }
}
