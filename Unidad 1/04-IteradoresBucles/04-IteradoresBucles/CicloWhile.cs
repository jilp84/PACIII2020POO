using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_IteradoresBucles
{
    class CicloWhile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("CICLO WHILE");
            Console.WriteLine("-------------------");

            int i = 1;

            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();

        }

    }
}
