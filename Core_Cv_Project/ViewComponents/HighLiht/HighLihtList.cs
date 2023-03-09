using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Cv_Project.ViewComponents.HighLiht
{
    public class HighLihtList :ViewComponent
    {
        HighlihtManager highlihtManager = new HighlihtManager(new EfHighlightDal());
        public IViewComponentResult Invoke()
        {
            var values = highlihtManager.TGetList();
            return View(values);
        }
    }
}
