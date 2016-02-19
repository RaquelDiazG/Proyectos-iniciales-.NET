using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1{

    class Program{

        static void Main(string[] args){

            Tablero tablero = new Tablero(5, 6);
            tablero.visualizar();

            tablero.levantar(3, 3);
            Console.WriteLine();
            tablero.visualizar();

            Console.Read();
        }
    }
}
