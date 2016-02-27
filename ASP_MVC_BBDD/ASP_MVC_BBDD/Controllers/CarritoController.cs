using ASP_MVC_BBDD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_MVC_BBDD.Controllers
{
    public class CarritoController : Controller
    {

        private tiendaEntities db = new tiendaEntities();

        // GET: Carrito
        public ActionResult AddProductCart(CarritoCompra cc,int id)
        {
            //Buscamos el producto
            Productos p = db.Productos.Find(id);
            //Añadimos el producto al carrito
            cc.Add(p);

            return RedirectToAction("Index","Productos");
        }

        public ActionResult Index(CarritoCompra cc)
        {
            return View(cc);
        }

        public ActionResult Buy(CarritoCompra cc)
        {
            //Crear pedido
            Pedido pedido = new Pedido();
            //Añadir productos del carrito a la BBDD de pedidos
            foreach(Productos p in cc){
                pedido.Id = 0;
                pedido.Id_producto = p.Id;
                db.Pedidoes.Add(pedido);
                db.SaveChanges();
            }
            //Vaciar carrito
            cc=new CarritoCompra();
            //Volver
            return RedirectToAction("Index", "Productos");
        }
    }
}