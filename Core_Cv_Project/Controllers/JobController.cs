using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Cv_Project.Controllers
{
    public class JobController : Controller
    {
        JobManager jobManager = new JobManager(new EfJobDal());
        public IActionResult Index(int id)
        {
            var values = jobManager.TGetList().Where(x=>x.Job_Id==id).ToList();
            return View(values);
        }
        public IActionResult Deneme()
        {
            return View();
        }
    }

}
