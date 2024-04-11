using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        ContactManager contactmanager = new ContactManager(new EFContactRepository());
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var vallues = contactmanager.GetListAllContact();
            return Ok(vallues);
        }
        [HttpPost]
        public async Task<IActionResult> Insert(Contact p)
        {
            contactmanager.TAdd(p);
            return Ok("Başarılı Bir Şekilde Eklendi...");
        }
        [HttpPut]
        public async Task<IActionResult> Update(Contact p)
        {
            contactmanager.TUpdate(p);
            return Ok("Başarılı Bir Şekilde Güncellendi...");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByID(int id)
        {
            var values = contactmanager.TGetByID(id);
            return Ok(values);
        }
    }
}
