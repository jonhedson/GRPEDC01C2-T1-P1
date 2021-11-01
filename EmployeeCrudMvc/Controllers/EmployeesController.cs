using Microsoft.AspNetCore.Mvc;
using EmployeeCrudMvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeCrudMvc.Controllers
{
    public class EmployeesController : Controller
    {

        #region BL
        private static List<Employee> allEmployees = new List<Employee>();

        public static IEnumerable<Employee> AllEmployees
        {
            get { return allEmployees; }
        }

        public static void CreateBL(Employee employee)
        {
            allEmployees.Add(employee);
        }

        public static void DeleteBL(Employee employee)
        {
            allEmployees.Remove(employee);
        }
        #endregion

        #region Controllers
        public IActionResult Index()
        {
            return View(AllEmployees);
        }

        // GET: EmployeesController/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            CreateBL(employee);
            return View("Thanks", employee);
        }

        // GET: EmployeesController/Edit/empname
        public ActionResult Edit(string empname)
        {
            Employee employee = AllEmployees.Where(e => e.Name == empname).FirstOrDefault();
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(Employee employee, string empname)
        {
            AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Age = employee.Age;
            AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Salary = employee.Salary;
            AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Department = employee.Department;
            AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Sex = employee.Sex;
            AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Name = employee.Name;

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(string empname)
        {
            Employee employee = AllEmployees.Where(e => e.Name == empname).FirstOrDefault();
            DeleteBL(employee);
            return RedirectToAction("Index");
        }

        #endregion
    }
}
