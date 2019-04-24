using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    [RoutePrefix("employees")]
    public class IndexController : Controller
    {
        [Route("")]
        [HttpGet]
        public ActionResult ListEmployee()
        {
            if(TempData.Peek("employees") == null)
            {
                List<Employee> employees = new List<Employee> {
                    new Employee{ EmployeeId = 100, FirstName = "Udin", LastName = "Jalaludin" },
                    new Employee{ EmployeeId = 101, FirstName = "Ice", LastName = "Juice" },
                    new Employee{ EmployeeId = 102, FirstName = "Ucup", LastName = "Aja" }
                };

                TempData["employees"] = employees;
            }
            return View("Index", TempData.Peek("employees"));
        }

        [Route("")]
        [HttpPost]
        [ActionName("NewEmployee")]
        public ActionResult AddEmployee(Employee employee)
        {
            List<Employee> employees = (List<Employee>)TempData.Peek("employees");
            employees.Add(employee);
            return Redirect("~/employees");
        }

        [Route("new")]
        [HttpGet]
        public ActionResult NewEmployee()
        {
            return View("EmployeeForm");
        }

        [Route("{id}")]
        [HttpGet]
        public ActionResult GetEmployee(int id)
        {
            List<Employee> employees = (List<Employee>)TempData.Peek("employees");
            Employee employee = employees.Find(e => e.EmployeeId == id);
            return View("Employee", employee);
        }

        [Route("{id}/edit")]
        [HttpGet]
        public ActionResult EditEmployee(int id)
        {
            List<Employee> employees = (List<Employee>)TempData.Peek("employees");
            Employee employee = employees.Find(e => e.EmployeeId == id);
            return View("EditForm", employee);
        }

        [Route("edit")]
        [HttpPost]
        public ActionResult UpdateEmployee(Employee edittedEmployee)
        {
            List<Employee> employees = (List<Employee>)TempData.Peek("employees");
            int index = employees.FindIndex(e => e.EmployeeId == edittedEmployee.EmployeeId);
            employees[index] = edittedEmployee;
            return Redirect("~/employees");
        }

        [Route("{id}/delete")]
        [HttpPost]
        public ActionResult DeleteEmployee(int id)
        {
            List<Employee> employees = (List<Employee>)TempData.Peek("employees");
            Employee employee = employees.Find(e => e.EmployeeId == id);
            employees.Remove(employee);
            return Redirect("~/employees");
        }
    }
}
