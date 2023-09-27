using Microsoft.AspNetCore.Mvc;
using MVC_Lap2.Models;

namespace MVC_Lap2
{
    public class EmployeeController : Controller
    {
        private EmployeeContext context;
        public EmployeeController()
        {
                context = new EmployeeContext();
        }
        public IActionResult Index()
        {
            List<Employee> employees = context.Employees.ToList();
            return View(employees);
        }
        public IActionResult Details(int id)
        {
            Employee employee=context.Employees.Where(e=>e.id==id).SingleOrDefault();
            if(employee==null) { 
          return Content("Error");
            }
            return View(employee);
        }
        public IActionResult NewForm()
        {
            return View();
        }
        public IActionResult addactionresult(Employee employee)
        {
            context.Employees.Add(employee);
          
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
