using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine(" Operaciones Basicas ");
            Console.WriteLine("----------------------\n");

            Console.WriteLine("Ingrese el primer numero:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero:");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEl resultado de las operaciones es:");
            Console.WriteLine("Suma: " + (numero1 + numero2));
            Console.WriteLine("Resta: " + (numero1 - numero2));
            Console.WriteLine("Multiplicacion: " + (numero1 * numero2));
            Console.WriteLine("Division: " + (numero1 / numero2));

            Console.ReadKey();


        }
    }
}
