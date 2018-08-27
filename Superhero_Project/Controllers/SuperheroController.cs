using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Superhero_Project.Models;

namespace Superhero_Project.Controllers
{
    public class SuperheroController : Controller
    {
    
        public ActionResult SuperheroList()
        {
            SuperheroContext db = new SuperheroContext();
            return View(db.Superhero);
        }
        public ActionResult SuperheroCreate(Superhero superhero)
        {
            SuperheroContext db = new SuperheroContext();
            db.Superhero.Add(superhero);
            db.SaveChanges();
            return View();
        }
        public ActionResult SuperheroDelete()
        {
            return View();
        }
        public ActionResult SuperheroDetails(int id = 0)
        {
            SuperheroContext db = new SuperheroContext();
            Superhero details = db.Superhero.Find(id);
            if (details == null)
            {
                return HttpNotFound();
            }
            return View(details);
        }
        public ActionResult Edit()
        {
            return View();
        }
        public ActionResult List()
        {
            return View();
        }
    }
}