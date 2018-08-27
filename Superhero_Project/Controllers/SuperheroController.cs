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
        
        // GET: Superhero
        public ActionResult Index()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            return View();
        }
        public ActionResult Create(Superhero superhero)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            db.Superheros.Add(superhero);
            db.SaveChanges();
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
        public ActionResult Details()
        {
            return View();
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