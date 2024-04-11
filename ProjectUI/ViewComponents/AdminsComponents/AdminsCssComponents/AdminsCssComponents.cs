using Microsoft.AspNetCore.Mvc;

namespace ProjectUI.ViewComponents.AdminsComponents.AdminsCssComponents
{
    public class AdminsCssComponents:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
