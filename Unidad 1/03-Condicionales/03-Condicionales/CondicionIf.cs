using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Condicionales
{
    class CondicionIf
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("CONDICIONAL IF");
            Console.WriteLine("------------------------------------\n");

            Console.WriteLine("Numero 1:");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero 2:");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("El primero numero es mayor");
            }
            else
            {
                Console.WriteLine("El primero numero es menor");
            }

            Console.ReadKey();

        }
    }
}
