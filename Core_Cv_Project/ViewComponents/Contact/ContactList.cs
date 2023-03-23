using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Core_Cv_Project.ViewComponents.Contact
{
    public class ContactList:ViewComponent
    {
        ContactManager _contactmanager = new ContactManager(new EfContactDal());
        public IViewComponentResult Invoke()
        {
            var values = _contactmanager.TGetList();
            return View(values);
        }
    }
}
