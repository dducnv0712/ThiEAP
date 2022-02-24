using Client.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Client.Controllers
{
    public class HomeController : Controller
    {
        static ServiceReference1.Service1Client serviceClient = new ServiceReference1.Service1Client();
        public ActionResult Index(string Department)
        {
           var res = serviceClient.GetAll(Department);
            return View(res.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeDto employeeDto)
        {
            serviceClient.Save(employeeDto);
            
            return RedirectToAction("Index");
        }
    }
}