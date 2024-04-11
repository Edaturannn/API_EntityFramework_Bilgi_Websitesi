using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProjectUI.ViewComponents.UsersComponents.UsersVisionComponents
{
    public class UsersVisionComponents:ViewComponent
    {
        VisionManager visionmanager = new VisionManager(new EFVisionRepository());
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = visionmanager.GetListAllVision();
            return View(values);
        }
    }
}
