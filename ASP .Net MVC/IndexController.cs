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
            using (HREntities hr = new HREntities()) {
                List<Employee> employees = hr.COPY_EMP.Select(e =>
                        new Employee
                        {
                            EmployeeId = (int)e.EMPLOYEE_ID,
                            FirstName = e.FIRST_NAME,
                            LastName = e.LAST_NAME
                        }).ToList();
                return View("Index", employees);
            }
        }

        [Route("")]
        [HttpPost]
        [ActionName("NewEmployee")]
        public ActionResult AddEmployee(Employee employee)
        {
            using (HREntities hr = new HREntities()) {
                COPY_EMP addedEmp = new COPY_EMP
                {
                    EMPLOYEE_ID = employee.EmployeeId,
                    FIRST_NAME = employee.FirstName,
                    LAST_NAME = employee.LastName
                };
                hr.COPY_EMP.Add(addedEmp);
                hr.SaveChanges();
                return Redirect("~/employees");
            }
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
            using(HREntities hr = new HREntities())
            {
                // Cara Kedua
                COPY_EMP empModel = hr.COPY_EMP.Find(id);
                Employee employee = new Employee {
                    EmployeeId = (int)empModel.EMPLOYEE_ID,
                    FirstName = empModel.FIRST_NAME,
                    LastName = empModel.LAST_NAME,
                };

                return View("COPY_EMP", employee);
            }
        }

        [Route("{id}/edit")]
        [HttpGet]
        public ActionResult EditEmployee(int id)
        {
            using (HREntities hr = new HREntities())
            {
                // Cara Kedua
                COPY_EMP empModel = hr.COPY_EMP.Find(id);
                Employee employee = new Employee
                {
                    EmployeeId = (int)empModel.EMPLOYEE_ID,
                    FirstName = empModel.FIRST_NAME,
                    LastName = empModel.LAST_NAME,
                };

                return View("EditForm", employee);
            }
        }

        [Route("edit")]
        [HttpPost]
        public ActionResult UpdateEmployee(Employee edittedEmployee)
        {
            using (HREntities hr = new HREntities())
            {
                COPY_EMP addedEmp = new COPY_EMP
                {
                    EMPLOYEE_ID = edittedEmployee.EmployeeId,
                    FIRST_NAME = edittedEmployee.FirstName,
                    LAST_NAME = edittedEmployee.LastName
                };
                hr.Entry(addedEmp).State = System.Data.Entity.EntityState.Modified;
                hr.SaveChanges();
                return Redirect("~/employees");
            }
        }

        [Route("{id}/delete")]
        [HttpPost]
        public ActionResult DeleteEmployee(int id)
        {
            using (HREntities hr = new HREntities())
            {
                COPY_EMP employee = hr.COPY_EMP.Find(id);
                hr.COPY_EMP.Remove(employee);
                hr.SaveChanges();
                return Redirect("~/employees");
            }
        }
    }
}