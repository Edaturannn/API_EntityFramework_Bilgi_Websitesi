using Microsoft.AspNetCore.Mvc;

namespace ProjectUI.ViewComponents.AdminsComponents.AdminsFooterComponents
{
    public class AdminsFooterComponents:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
