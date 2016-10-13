using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZoolandiaRazor.DAL;
using ZoolandiaRazor.Models;

namespace ZoolandiaRazor.Controllers
{
    public class EmployeeController : Controller
    {
        ZooRepository Repo = new ZooRepository();

        public ActionResult Index()
        {
            ViewBag.Employees = Repo.GetAllEmployees();
            return View();
        }

        public ActionResult Detail(int id)
        {
            ViewBag.Employee = Repo.GetSingleEmployee(id);
            ViewBag.Age = DateTime.Now.Year - ViewBag.Employee.BirthDate.Year;
            ViewBag.Habitats = ViewBag.Employee.AssignedHabitats;

            if (ViewBag.Employee == null)
            {
                return View("Index");
            }
            else
            {
                return View("Detail", ViewBag.Employee);
            }
        }
    }
}