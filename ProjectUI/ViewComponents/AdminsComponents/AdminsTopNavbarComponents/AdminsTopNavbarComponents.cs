using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProjectUI.ViewComponents.AdminsComponents.AdminsTopNavbarComponents
{
    public class AdminsTopNavbarComponents: ViewComponent
    {
        Context context = new Context();
        ContactManager contactmanager = new ContactManager(new EFContactRepository());
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.MessageCount = context.Contacts.Count();
            var values = contactmanager.GetListAllContact();
            return View(values);
        }
    }
}
