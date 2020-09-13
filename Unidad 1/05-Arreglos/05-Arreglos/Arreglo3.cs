using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Arreglos
{
    class Arreglo3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("ARREGLOS");
            Console.WriteLine("-----------------");

            int[] arreglo = new int[5];

            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write("ARREGLO[{0}] = ", i);
                arreglo[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();

        }
    }
}
