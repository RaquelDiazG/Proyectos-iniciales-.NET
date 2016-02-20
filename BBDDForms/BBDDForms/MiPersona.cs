using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDDForms
{
    partial class MiPersona:Persona
    {
        
         public override string ToString()
        {
            return "Id: " + Id + " Nombre: " + Nombre + " Apellidos:" + Apellidos;
        }
    }
}
