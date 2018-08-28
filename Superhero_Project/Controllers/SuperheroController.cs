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
        public ActionResult SuperheroCreate(int? id)
        {
            SuperheroContext db = new SuperheroContext();
            Superhero createHero = db.Superhero.SingleOrDefault(identity => identity.Id == 0);
            return View(createHero);
        }
        [HttpPost]
        public ActionResult SuperheroCreate(Superhero superhero)
        {
            SuperheroContext db = new SuperheroContext();
            db.Superhero.Add(superhero);
            db.SaveChanges();
            return RedirectToAction("SuperheroList");
        }
        public ActionResult SuperheroDelete(int? id)
        {
            SuperheroContext db = new SuperheroContext();
            Superhero heroDelete = db.Superhero.SingleOrDefault(identity => identity.Id == id);
            return View(heroDelete);
        }
        [HttpPost]
        public ActionResult SuperheroDelete(int id)
        {
            SuperheroContext db = new SuperheroContext();
            Superhero heroDelete = db.Superhero.SingleOrDefault(identity => identity.Id == id);
            db.Superhero.Remove(heroDelete);
            db.SaveChanges();
            return RedirectToAction("SuperheroList");
        }
        public ActionResult SuperheroDetails(int? id)
        {
            SuperheroContext db = new SuperheroContext();
            Superhero details = db.Superhero.SingleOrDefault(identity => identity.Id == id);
            if (details == null)
            {
                return HttpNotFound();
            }
            return View(details);
        }
        public ActionResult SuperheroEdit(int? id)
        {
            SuperheroContext db = new SuperheroContext();
            Superhero heroEdit = db.Superhero.SingleOrDefault(identity => identity.Id == id);
            return View(heroEdit);
        }
        [HttpPost]
        public ActionResult SuperheroEdit(Superhero superhero)
        {
            SuperheroContext db = new SuperheroContext();
            db.Entry(superhero).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("SuperheroList");
        }
    }
}