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
            Dictionary<string, int> animalCount = new Dictionary<string, int>();
            ZooRepository repo = new ZooRepository();
            //animalCount = repo.AnimalsInEachHabitat();
            //ViewBag.message = "Dog";
            ViewBag.animalCount = repo.AnimalsInEachHabitat();
            return View();
        }
    }
}