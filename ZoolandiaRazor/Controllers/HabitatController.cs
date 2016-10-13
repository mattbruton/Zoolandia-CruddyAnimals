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
            ViewBag.animalCount = repo.GetAllHabitats();
            return View();
        }

        public ActionResult Details(int id)
        {
            ViewBag.habitatDetail = repo.IndividualHabitat(id);
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

        
        public ActionResult Update(int id)
        {
            return View();
        }

        [HttpPut]
        [ValidateAntiForgeryToken]
        public ActionResult Update(Habitat habitat)
        {
            repo.UpdateHabitat(habitat);
            return RedirectToAction("Detail");
            return View();
        }
    }
}