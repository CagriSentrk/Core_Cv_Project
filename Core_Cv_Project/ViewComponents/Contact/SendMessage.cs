using BussinesLayer.Concrete;
using EntityLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using DataAccessLayer.Concrete;
using System.Xml.Linq;
namespace Core_Cv_Project.ViewComponents.Contact
{

    public class SendMessage:ViewComponent
    {
  
        public IViewComponentResult Invoke()
        {     
           
            return View();  
        }
    }
}
