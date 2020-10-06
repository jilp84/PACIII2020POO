using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_herencia
{
    public class Profesor : Empleado
    {
        public string Area { get; set; }

        public void BuscarSalario() 
        {
            Salario = 4000;
        }

        public void SetValues2()
        {
            Puesto = "Profesor";
            Area = "Matematicas";
        }

    }
}
