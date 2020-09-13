using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Condicionales
{
    class CondicionalSwitch
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("CONDICIONAL SWITCH");
            Console.WriteLine("--------------------------");

            Console.WriteLine("Ingrese un numero de dia");
            int dia = int.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;

                default:
                    Console.WriteLine("No es un dia de la semana.");
                    break;
            }

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();

        }
    }
}
