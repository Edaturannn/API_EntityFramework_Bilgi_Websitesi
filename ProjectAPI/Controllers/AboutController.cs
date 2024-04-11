
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        AboutManager aboutmanager = new AboutManager(new EFAboutRepository());

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var values = aboutmanager.GetListAllAbout();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> Insert(About p)
        {
            aboutmanager.TAdd(p);
            return Ok("Başarılı Bir Şekilde Eklendi...");
        }
        [HttpPut]
        public async Task<IActionResult> Update(About p)
        {
            aboutmanager.TUpdate(p);
            return Ok("Başarılı Bir Şekilde Güncellendi...");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByID(int id)
        {
            var values = aboutmanager.TGetByID(id);
            return Ok(values);
        }
    }
}
