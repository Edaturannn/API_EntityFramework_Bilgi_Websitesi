using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProjectUI.ViewComponents.UsersComponents.UsersCategoryComponents
{
    public class UsersCategoryComponents:ViewComponent
    {
        CategoryManager categorymanager = new CategoryManager(new EFCategoryRepository());
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = categorymanager.GetListAllCategory();
            return View(values);
        }
    }
}
