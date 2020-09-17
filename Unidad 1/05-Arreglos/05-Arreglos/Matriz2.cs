using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Arreglos
{
    class Matriz2
    {
        static void Main() 
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Matrices");
            Console.WriteLine("---------------------\n");

            int[,] matriz = new int[2, 3];

            Console.WriteLine("FILAS: {0}", matriz.GetLength(0));
            Console.WriteLine("COLUMNAS: {0} \n", matriz.GetLength(1));

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("MATRIZ[{0},{1}] = ", i, j);
                    matriz[i, j] = int.Parse( Console.ReadLine());
                }
            }

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();

        }
    }
}
