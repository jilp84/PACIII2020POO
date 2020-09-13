using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Arreglos
{
    class Arreglo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("ARREGLOS");
            Console.WriteLine("-----------------");

            int[] x = {12,2,9,25,90,155,11,74,80,60};

            //Console.WriteLine(x);

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("ARREGLO[{0}] = {1}", i, x[i]);
                //Console.WriteLine("ARREGLO[" + i + "] = " + x[i]);
            }

            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();

        }
    }
}
