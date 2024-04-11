using Microsoft.AspNetCore.Mvc;

namespace ProjectUI.ViewComponents.AdminsComponents.AdminsNavbarComponents
{
    public class AdminsNavbarComponents:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
