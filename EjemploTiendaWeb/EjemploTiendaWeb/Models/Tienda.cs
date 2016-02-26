using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjemploTiendaWeb.Models
{
    public class Tienda:List<Producto>
    {
        private static Tienda tienda;

        private Tienda()
        {
         
        }

        public static Tienda getInstance()
        {
            if (tienda == null)
            {
                tienda = new Tienda();
            } 
            return tienda;
        }
    }
}