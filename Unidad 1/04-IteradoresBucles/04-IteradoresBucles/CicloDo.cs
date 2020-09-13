using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_IteradoresBucles
{
    class CicloDo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("CICLO DO");
            Console.WriteLine("------------------");

            int i = 10;

            do
            {
                Console.WriteLine(i);
                i--;
            } while (i >= 1);

            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }
    }
}
