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
        ZooRepository repo = new ZooRepository();
        

        // GET: Habitat
        public ActionResult Index()
        {
            ViewBag.animalCount = repo.AnimalCountInEachHabitat();
            return View();
        }

        public ActionResult Details(int id)
        {
            ViewBag.habitatDetail = repo.habitatTable(id);
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Habitat habitat)
        {
            if(ModelState.IsValid)
            {
                repo.AddHabitat(habitat);
                return RedirectToAction("Index");
            }

            return View(habitat);
        }
    }
}