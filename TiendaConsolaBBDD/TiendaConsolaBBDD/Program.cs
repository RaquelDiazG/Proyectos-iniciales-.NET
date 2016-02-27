using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIendaConsolaBBDD;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conexion a la BBDD
            tiendaEntities tienda = new tiendaEntities();

            //Creamos una persona
            Persona p1 = new Persona();
            p1.Nombre = "persona1";

            //Añadimos una persona
            tienda.Personas.Add(p1);

            //Actualizar BBDD
            tienda.SaveChanges();

            //Consulta LINQ
            var res =
                from persona in tienda.Personas
                select new { persona.Edad,persona.Nombre }
                ;
            foreach(var p in res){
                Console.WriteLine(p);
            }

            Console.WriteLine("--------------------------------");

            //Consulta LINQ con proyecciones
            var res2 =
                from persona in tienda.Personas
                select new { old=persona.Edad+10, persona.Nombre,viejo=(persona.Edad>20) }
                ;
            foreach (var p in res2)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("--------------------------------");

            //Consulta LINQ con where
            var res3 =
                from persona in tienda.Personas
                where persona.Edad>20
                select new { persona.Edad, persona.Nombre }
                ;
            foreach (var p in res3)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("--------------------------------");

            //Consulta LINQ union
            var res4 =
                from persona in tienda.Personas
                from factura in tienda.Facturas
                where persona.Edad > 20 && factura.Precio<1000
                select new { 
                    persona.Edad, 
                    persona.Nombre,
                    factura.Precio
                }
                ;
            foreach (var p in res4)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("--------------------------------");

            //Consulta con expresiones lambda
            var res5= tienda.Personas
                .Where(p=>p.Edad>10)
                .Select(x=>x.Nombre);
            foreach (var p in res5)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("--------------------------------");

            Console.Read();
        }
    }
}
