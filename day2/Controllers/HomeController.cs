using day2.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Day2.Models;

namespace MVC_Day2.Controllers
{
    public class HomeController : Controller
    {
        CompanyContext db = new CompanyContext();

        public IActionResult Index()
        {
            return View();
        }

        // View → Controller
        public IActionResult AddEmp()
        {
            return View();
        }

        public IActionResult AddEmployee(Employee emp)
        {
            db.Employees.Add(emp);
            db.SaveChanges();

            return Content(emp.ToString());
        }

        // Controller → View
        public IActionResult GetEmp(int id)
        {
            var emp = db.Employees
                .Include(e => e.Department)
                .FirstOrDefault(e => e.Id == id);

            return View(emp);
        }

        // Controller → View
        public IActionResult GetAllEmps()
        {
            var employees = db.Employees
                .Include(e => e.Department)
                .ToList();

            return View(employees);
        }
    }
}