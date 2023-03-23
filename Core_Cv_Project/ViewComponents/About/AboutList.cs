using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Cv_Project.ViewComponents.About
{
    public class AboutList:ViewComponent
    {
        AboutManager aboutManager=new AboutManager(new EfAboutDal());

        public IViewComponentResult Invoke()
        {
            var values=aboutManager.TGetList();

            return View(values);

        }
    }
}
