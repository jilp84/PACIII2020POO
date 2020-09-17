using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Arreglos
{
    class Matriz1
    {
        static void Main() 
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Matrices");
            Console.WriteLine("---------------------");

            int[,] matriz = new int[3, 3] { { 2, 20, 45},
                                            { 36, 1, 69},
                                            { 74, 3, 50}
                                          };

            Console.WriteLine("FILAS: {0}", matriz.GetLength(0));
            Console.WriteLine("COLUMNAS: {0} \n", matriz.GetLength(1));

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (j == 2)
                    {
                        Console.Write(matriz[i, j] + "\n");
                    }
                    else
                    {
                        Console.Write(matriz[i, j] + "\t");
                    }                    
                }
            }

            Console.WriteLine("\n\nPresione una tecla para continuar...");
            Console.ReadKey();

        }
    }
}
