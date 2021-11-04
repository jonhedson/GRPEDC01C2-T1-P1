using Microsoft.AspNetCore.Mvc;
using EmployeeCrudMvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeCrudMvc.Controllers
{
    public class EmployeesController : Controller
    {

        public IActionResult Index()
        {
            return View(Repository.AllEmployees);
        }

        // GET: EmployeesController/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            Repository.Create(employee);
            return View("Thanks", employee);
        }

        // GET: EmployeesController/Edit/empname
        public ActionResult Edit(string empname)
        {
            Employee employee = Repository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault();
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(Employee employee, string empname)
        {

            Repository.Edit(employee, empname);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(string empname)
        {
            Employee employee = Repository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault();
            Repository.Delete(employee);
            return RedirectToAction("Index");
        }

    }
}
