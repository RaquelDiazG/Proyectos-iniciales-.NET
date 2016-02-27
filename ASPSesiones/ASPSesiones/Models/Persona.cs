using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPSesiones.Models
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad {get;set;}

        public override string ToString()
        {
            return "Nombre: "+Nombre + " Edad: "+Edad;
        }
    }
}