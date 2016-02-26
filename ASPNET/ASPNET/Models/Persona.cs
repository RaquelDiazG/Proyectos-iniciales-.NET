using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNET.Models
{
    public class Persona
    {
        public string Nombre {get;set;}

        public override string ToString()
        {
            return Nombre;
        }
    }
}