using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("COMPARAR NUMEROS - OPERADOR TERNARIO");
            Console.WriteLine("------------------------------------\n");
            
            Console.WriteLine("Numero 1:");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero 2:");
            int numero2 = int.Parse(Console.ReadLine());

            //string flag = numero1 == numero2 ? "Iguales" : "Distintos";

            Console.WriteLine("Los numeros son: " + (numero1 == numero2 ? "Iguales" : "Distintos"));

            Console.ReadKey();

        }
    }
}
