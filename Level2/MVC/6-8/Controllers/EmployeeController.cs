using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _6.Models;

namespace _6.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details(int id)
        {
            //this is code is for video 7 PS: remove int id parameter
            /*Employee employee = new Employee()
            {
                Id = 804,
                Name = "Dhruv",
               Gender = "Male",
                Email = "dhruv@gmail.com"
               };

            return View(employee);*/



            //this code is for video 8
            EmployeeContext emp = new EmployeeContext();
            Employee employee = emp.Employees.Single(empi => empi.Id == id); 
            return View(employee);
        }
        public ActionResult Index()
        {
            ViewData["YourData"] = "ViewData";
            ViewBag.MyData = "ViewBag";
            return View();
        }
    }
}