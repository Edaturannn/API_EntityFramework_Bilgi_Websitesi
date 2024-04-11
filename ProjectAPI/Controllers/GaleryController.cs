using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GaleryController : ControllerBase
    {
        GaleryManager galerymanager = new GaleryManager(new EFGaleryRepository());
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var values = galerymanager.GetListAllGalery();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> Insert(Galery p)
        {
            galerymanager.TAdd(p);
            return Ok("Başarılı Bir Şekilde Eklendi...");
        }
        [HttpPut]
        public async Task<IActionResult> Update(Galery p)
        {
            galerymanager.TUpdate(p);
            return Ok("Başarılı Bir Şekilde Güncellendi...");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByID(int id)
        {
            var values = galerymanager.TGetByID(id);
            return Ok(values);
        }
    }
}
