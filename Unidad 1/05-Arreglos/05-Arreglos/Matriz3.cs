using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Arreglos
{
    class Matriz3
    {
        private int[,] mat;

        public void Cargar()
        {

            Console.Write("Indique las filas de la matriz");
            int filas = int.Parse(Console.ReadLine());

            Console.Write("Indique las columnas de la matriz");
            int columnas = int.Parse(Console.ReadLine());

            mat = new int[filas, columnas];

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write("MATRIZ[{0},{1}] = ", i, j);
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

        }

        public void Imprimir() 
        {
            Console.WriteLine("Toda la Matriz");

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (j == (mat.GetLength(1)-1))
                    {
                        Console.Write(mat[i, j] + "\n");
                    }
                    else
                    {
                        Console.Write(mat[i, j] + "\t");
                    }
                }
            }
        }

        public void ImprimirUltimaLinea() 
        {
            Console.WriteLine("\nUltima Linea");
            for (int i = 0; i < mat.GetLength(1); i++)
            {
                Console.Write(mat[mat.GetLength(0) - 1, i] + "\t");
            }

        }

        static void Main() 
        {
            Matriz3 m = new Matriz3();

            Console.WriteLine("---------------------");
            Console.WriteLine("Matrices");
            Console.WriteLine("---------------------\n");

            m.Cargar();
            m.Imprimir();
            m.ImprimirUltimaLinea();

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();

        }

    }
}
