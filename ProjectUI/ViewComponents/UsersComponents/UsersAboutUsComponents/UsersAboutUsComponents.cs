using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ProjectUI.ViewComponents.UsersComponents.UsersAboutUsComponents
{
    public class UsersAboutUsComponents:ViewComponent
    {
        AboutManager aboutmanager = new AboutManager(new EFAboutRepository());
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = aboutmanager.GetListAllAbout();
            return View(values);
        }
    }
}
