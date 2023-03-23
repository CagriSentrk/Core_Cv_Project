using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Cv_Project.ViewComponents.Job
{
    public class JobList:ViewComponent
    {
        JobManager _jobmanager = new JobManager(new EfJobDal());

        public IViewComponentResult Invoke()
        {
            var values = _jobmanager.TGetList();
            return View(values);
        }
    }
}
