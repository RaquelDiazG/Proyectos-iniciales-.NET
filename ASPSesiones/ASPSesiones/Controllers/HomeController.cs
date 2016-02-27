using ASPSesiones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPSesiones.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(Persona p)
        {
            //Session["key_usuario"] = "hola";

            //MODEL BINDER
            p.Nombre = "juan";
            p.Edad = 18;

            return View(p);
        }
    }
}