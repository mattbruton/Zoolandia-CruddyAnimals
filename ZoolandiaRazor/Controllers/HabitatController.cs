using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZoolandiaRazor.DAL;
using ZoolandiaRazor.Models;

namespace ZoolandiaRazor.Controllers
{
    public class HabitatController : Controller
    {
        // GET: Habitat
        public ActionResult Index()
        {
            ZooRepository repo = new ZooRepository();
            ViewBag.animalCount = repo.AnimalCountInEachHabitat();
            return View();
        }

        public ActionResult Details(int id)
        {
            ZooRepository repo = new ZooRepository();
            var habitatDetail = repo.habitatTable(id);
            return View(habitatDetail);
        }
    }
}