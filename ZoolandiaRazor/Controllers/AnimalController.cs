using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZoolandiaRazor.DAL;
using ZoolandiaRazor.Models;
using ZoolandiaRazor.Migrations;

namespace ZoolandiaRazor.Controllers
{
    public class AnimalController : Controller
    {
        ZooRepository repo = new ZooRepository();
        // GET: Animal
        public ActionResult Index()
        {
            ViewBag.Animals = repo.GetAnimals();
            return View();
        }

        public ActionResult Details()
        {
            ViewBag.Animals = repo.GetAnimals();
            return View();
        }
    }
}