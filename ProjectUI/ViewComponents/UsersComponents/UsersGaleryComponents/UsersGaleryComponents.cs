using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProjectUI.ViewComponents.UsersComponents.UsersGaleryComponents
{
    public class UsersGaleryComponents:ViewComponent
    {
        GaleryManager galerymanager = new GaleryManager(new EFGaleryRepository());
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = galerymanager.GetListAllGalery();
            return View(values);
        }
    }
}
