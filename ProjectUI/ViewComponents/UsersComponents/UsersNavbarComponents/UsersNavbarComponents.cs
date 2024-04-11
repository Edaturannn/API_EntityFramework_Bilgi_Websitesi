using Microsoft.AspNetCore.Mvc;

namespace ProjectUI.ViewComponents.UsersComponents.UsersNavbarComponents
{
    public class UsersNavbarComponents : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
