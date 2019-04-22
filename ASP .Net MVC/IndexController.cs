using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    [RoutePrefix("employees")]
    public class IndexController : Controller
    {
        [Route("")]
        [HttpGet]
        public ActionResult ListEmployee() {
            ViewBag.listEmployee = "List employee";
            return View("Index");
        }

        [Route("")]
        [HttpPost]
        public ActionResult AddEmployee()
        {
            return Redirect("employees");
        }

        [Route("new")]
        [HttpGet]
        public ActionResult NewEmployee()
        {
            return View("EmployeeForm");
        }

        [Route("{id}")]
        [HttpGet]
        public ActionResult GetEmployee(int id) {
            ViewBag.employee = id;
            return View("Employee");
        }

        [Route("{id}/edit")]
        [HttpGet]
        public ActionResult EditEmployee(int id) {
            ViewBag.employee = id;
            return View("EmployeeForm");
        }

        [Route("{id}/edit")]
        [HttpPut]
        public ActionResult UpdateEmployee(int id) {
            return Redirect("employees");
        }

        [Route("{id}/delete")]
        [HttpDelete]
        public ActionResult DeleteEmployee(int id) {
            return Redirect("employees");
        }
    }
}