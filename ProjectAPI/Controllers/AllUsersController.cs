using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllUsersController : ControllerBase
    {
        AllUsersManager allusersmanager = new AllUsersManager(new EFAllUsersRepository());
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var values = allusersmanager.GetListAllUsers();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> Insert(AllUsers p)
        {
            allusersmanager.TAdd(p);
            return Ok("Başarılı Bir Şekilde Eklendi...");
        }
        [HttpPut]
        public async Task<IActionResult> Update(AllUsers p)
        {
            allusersmanager.TUpdate(p);
            return Ok("Başarılı Bir Şekilde Güncellendi...");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByID(int id)
        {
            var values = allusersmanager.TGetByID(id);
            return Ok(values);
        }
    }
}
