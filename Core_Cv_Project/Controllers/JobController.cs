using BussinesLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System;
using Microsoft.AspNetCore.Hosting;

namespace Core_Cv_Project.Controllers
{
    public class JobController : Controller
    {
        JobManager jobManager = new JobManager(new EfJobDal());
        public IActionResult Index(int id)
        {
            ViewBag.v2 = id;
            var values = jobManager.TGetList().Where(x => x.Job_Id == id).ToList();
            return View(values);
        }

        public PartialViewResult SendCv(Employee c)
        {


            EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeDal());
            employeeManager.TAdd(c);
            return PartialView();
        }
        [HttpGet]
        public IActionResult ImageUpload()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> FileUpload(IFormFile formFile,Employee model)
            {
            if (formFile != null)
            { 

                var extent = Path.GetExtension(formFile.FileName);
                if (extent.ToLower() != ".pdf")
                {
                    ModelState.AddModelError("File", "Sadece PDF dosyaları yükleyebilirsiniz.");
                    return RedirectToAction("Index", "Default");
                }
                var randomName = ($"{Guid.NewGuid()}{extent}");
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img",randomName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }

                EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeDal());
                model.Cv = randomName;
                employeeManager.TAdd(model);

            }
            else
            {
                ModelState.AddModelError("File", "Lütfen bir dosya seçin.");
                return RedirectToAction("Index", "Default");
            }
            return RedirectToAction("Index","Default");
        }



    }

}
