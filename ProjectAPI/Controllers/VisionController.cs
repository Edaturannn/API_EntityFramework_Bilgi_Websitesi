using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisionController : ControllerBase
    {
        VisionManager visionmanager = new VisionManager(new EFVisionRepository());
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var values = visionmanager.GetListAllVision();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> Insert(Vision p)
        {
            visionmanager.TAdd(p);
            return Ok("Başarılı Bir Şekilde Eklendi...");
        }
        [HttpPut]
        public async Task<IActionResult> Update(Vision p)
        {
            visionmanager.TUpdate(p);
            return Ok("Başarılı Bir Şekilde Güncellendi...");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByID(int id)
        {
            var values = visionmanager.TGetByID(id);
            return Ok(values);
        }
    }
}
