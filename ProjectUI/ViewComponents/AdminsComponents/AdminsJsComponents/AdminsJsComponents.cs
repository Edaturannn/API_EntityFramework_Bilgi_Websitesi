using Microsoft.AspNetCore.Mvc;

namespace ProjectUI.ViewComponents.AdminsComponents.AdminsJsComponents
{
    public class AdminsJsComponents:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
