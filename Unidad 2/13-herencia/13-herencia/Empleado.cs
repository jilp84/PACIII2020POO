using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_herencia
{
    public class Empleado : Humano
    {
        public string Puesto { get; set; }
        public double Salario { get; set; }

        public void SetValues()
        {
            Nombre = "Juan ";
            Apellido = "Perez";
            Id = 1;
            Genero = 'M';
            Edad = 30;
        }

    }
}
