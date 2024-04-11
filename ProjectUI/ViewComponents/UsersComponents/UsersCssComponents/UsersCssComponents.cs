using Microsoft.AspNetCore.Mvc;

namespace ProjectUI.ViewComponents.UsersComponents.UsersCssComponents
{
    public class UsersCssComponents : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
