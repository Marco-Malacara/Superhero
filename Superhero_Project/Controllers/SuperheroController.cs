using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Superhero_Project.Controllers
{
    public class SuperheroController : Controller
    {
        // GET: Superhero
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult Create()
        {
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