using ServicioWebConsola.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioWebConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            GlobalWeatherSoap ws = new GlobalWeatherSoapClient("GlobalWeatherSoap");
            Console.WriteLine(ws.GetWeather("Madrid", "Spain"));
            Console.ReadLine();
        }
    }
}
