using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPSesiones.Models.Binders
{
    public class PersonaModelBinder:IModelBinder
    {

        private const string SessionKey = "key_persona";

        public object BindModel(ControllerContext modelBindingExecutionContext, ModelBindingContext bindingContext)
        {
            Persona persona = (modelBindingExecutionContext.HttpContext.Session != null) ? (modelBindingExecutionContext.HttpContext.Session[SessionKey] as Persona) : null;

            if (persona == null)
            {
                persona = new Persona();
                modelBindingExecutionContext.HttpContext.Session[SessionKey] = persona;
            }

            return persona;
        }
    }
}