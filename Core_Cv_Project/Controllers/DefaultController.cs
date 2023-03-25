using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Cv_Project.Controllers
{
    
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult SendMessage(Contact c)
        {
            ContactManager contactmanager = new ContactManager(new EfContactDal());
            contactmanager.TAdd(c);
            return PartialView();      //düzelt burayı.(Mesajı gönderince Partiala gidiyor direkt.)
        }
    }
}
