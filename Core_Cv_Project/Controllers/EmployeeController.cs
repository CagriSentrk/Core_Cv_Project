using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using System;
using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace Core_Cv_Project.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult ImageUpload()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> FileUpload(IFormFile formFile,Employee model )
        {
            if (formFile != null)
            { 

                var extent = Path.GetExtension(formFile.FileName);
                var randomName = ($"{Guid.NewGuid()}{extent}");
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", randomName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }
                model.Content = randomName;
                EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeDal());
                employeeManager.TAdd(model);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> FileUpload(Employee model, IFormFile formFile)
        {
            if (formFile != null)
            {
                var extent = Path.GetExtension(formFile.FileName);
                var randomName = ($"{Guid.NewGuid()}{extent}");
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", randomName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }

                model.Content = randomName;
                EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeDal());
                employeeManager.TAdd(model);
            }

            return View();
        }
    }
}
