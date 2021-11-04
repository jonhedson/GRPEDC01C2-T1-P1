using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCrudMvc.Models
{
    public static class Repository
    {
        private static List<Employee> allEmployees = new List<Employee>();

        public static IEnumerable<Employee> AllEmployees
        {
            get { return allEmployees; }
        }

        public static void Create(Employee employee)
        {
            allEmployees.Add(employee);
        }

        public static void Delete(Employee employee)
        {
            allEmployees.Remove(employee);
        }

        public static void Edit(Employee employee, string empname) 
        {
            AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Age = employee.Age;
            AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Salary = employee.Salary;
            AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Department = employee.Department;
            AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Sex = employee.Sex;
            AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Name = employee.Name;
        }
    }
}
