using EjemploTiendaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjemploTiendaWeb.Controllers
{
    public class TiendaController : Controller
    {
        // GET: Tienda
        public ActionResult Index()
        {
            return View(Tienda.getInstance());
        }

        // GET: Tienda/Details/5
        public ActionResult Details(int id)
        {
            Producto p = Tienda.getInstance().Find(x => x.Id == id);
            return View(p);
        }

        // GET: Tienda/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tienda/Create
        [HttpPost]
        public ActionResult Create(Producto p)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // TODO: Add insert logic here
                    if (Tienda.getInstance().Count == 0)
                    {
                        p.Id = 0;
                    }
                    else
                    {
                        p.Id = Tienda.getInstance().Max(x => x.Id) + 1;
                    }
                    Tienda.getInstance().Add(p);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Tienda/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Tienda.getInstance().Find(x => x.Id == id));
        }

        // POST: Tienda/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Producto p)
        {
            try
            {
                // TODO: Add update logic here
                Producto p_original=Tienda.getInstance().Find(x => x.Id == id);
                p_original.Nombre = p.Nombre;
                p_original.Precio = p.Precio;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tienda/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tienda/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Producto p)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
