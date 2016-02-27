using ASPSesiones.Models;
using ASPSesiones.Models.Binders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASPSesiones
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //Registrar los model binders
            ModelBinders.Binders.Add(typeof(Persona), new PersonaModelBinder());
        }
    }
}
