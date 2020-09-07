using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buenas tardes, por favor ingrese su nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine("Hola: " + nombre + " bienvenido.");

            Console.ReadKey();
        }
    }
}
