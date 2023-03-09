using Microsoft.AspNetCore.Mvc;

namespace Core_Cv_Project.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
