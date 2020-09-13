using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_IteradoresBucles
{
    class CicloFor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("CICLO FOR");
            Console.WriteLine("---------------------------");

            for (int i = 10; i >= 1; i--) 
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();

        }
    }
}
