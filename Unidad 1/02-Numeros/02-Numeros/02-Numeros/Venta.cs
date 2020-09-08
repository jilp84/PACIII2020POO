using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Numeros
{
    class Venta
    {

        static void Main(string[] args) 
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("CALCULO DEL IMPUESTO SOBRE VENTA");
            Console.WriteLine("--------------------------------\n");

            Console.WriteLine("Ingrese el monto total de la venta:");
            float valorTotal = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el el impuesto vigente:");
            float porcentajeImpuesto = float.Parse(Console.ReadLine());

            float impuestoPagar = valorTotal * porcentajeImpuesto;

            Console.WriteLine("El valor total mas el impuesto es: " + (impuestoPagar+valorTotal));

            Console.ReadKey();

        }

    }
}
