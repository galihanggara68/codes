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
            if(TempData.Peek("names") == null) {
                List<string> names = new List<string> { "Ucup", "Udin", "Ujang" };
                TempData["names"] = names;
            }
            return View("Index");
        }

        [Route("")]
        [HttpPost]
        public ActionResult AddEmployee(string name)
        {
            List<string> names = (List<string>)TempData.Peek("names");
            names.Add(name);
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
        public ActionResult GetEmployee(int id) {
            List<string> names = (List<string>)TempData.Peek("names");
            ViewBag.name = names[id];
            return View("Employee");
        }

        [Route("{id}/edit")]
        [HttpGet]
        public ActionResult EditEmployee(int id) {
            List<string> names = (List<string>)TempData.Peek("names");
            ViewBag.id = id;
            ViewBag.name = names[id];
            return View("EmployeeForm");
        }

        [Route("{id}/edit")]
        [HttpPost]
        public ActionResult UpdateEmployee(int id, string name) {
            List<string> names = (List<string>)TempData.Peek("names");
            names[id] = name;
            return Redirect("~/employees");
        }

        [Route("{id}/delete")]
        [HttpPost]
        public ActionResult DeleteEmployee(int id) {
            List<string> names = (List<string>)TempData.Peek("names");
            names.RemoveAt(id);
            return Redirect("~/employees");
        }
    }
}