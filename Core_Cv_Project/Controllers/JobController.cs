﻿using BussinesLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
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
        [HttpGet]

        public PartialViewResult SendCv()
        {
            ViewBag.v1 ="deneme";

            return PartialView();
        }


        [HttpPost]
        public PartialViewResult SendCv(Employee c)
        {
            

            EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeDal());
            employeeManager.TAdd(c);
            return PartialView();
        }

    }

}
