using ASPNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNET.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Persona p = new Persona();
            p.Nombre = "Raquel";
            //@TempData["usuario"] = p;
            return View(p);
            //return View("Listado");
            //return RedirectToAction();
        }

        public ActionResult valida()
        {
            return View("Index");
        }
        public ActionResult Formulario()
        {
            return View("Formulario");
        }
    }
}