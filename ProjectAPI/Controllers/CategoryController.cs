using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        CategoryManager categorymanager = new CategoryManager(new EFCategoryRepository());
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var values = categorymanager.GetListAllCategory();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> Insert(Category p)
        {
            categorymanager.TAdd(p);
            return Ok("Başarılı Bir Şekilde Eklendi...");
        }
        [HttpPut]
        public async Task<IActionResult> Update(Category p)
        {
            categorymanager.TUpdate(p);
            return Ok("Başarılı Bir Şekilde Güncellendi...");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByID(int id)
        {
            var values = categorymanager.TGetByID(id);
            return Ok(values);
        }
    }
}
